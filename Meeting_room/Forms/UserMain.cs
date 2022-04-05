using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Meeting;

namespace Meeting_room
{
    public partial class UserMain : Form
    {
        public UserMain()
        {
            InitializeComponent();
        }        
        private void MeetList_AddValue(string command, string lastIdCheck)
        {
            meetList.Items.Clear();
            SqlUse.connection.Open();
            SqlCommand sqlLastIdCheck = new SqlCommand(lastIdCheck, SqlUse.connection);
            SqlDataReader readerId = sqlLastIdCheck.ExecuteReader();
            readerId.Read();
            int lastId = Convert.ToInt32(readerId[0]);
            readerId.Close();
            SqlCommand sqlCommand = new SqlCommand(command, SqlUse.connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[lastId]);
                for (int i = 0; i < lastId; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            foreach (string[] s in data)
            {
                var parsedDate = DateTime.Parse(s[3]);
                if ((parsedDate.Day == meetTime.Value.Day)
                    && (parsedDate.Month == meetTime.Value.Month)
                    && (parsedDate.Year == meetTime.Value.Year) || (meetSearch.Text != "Поиск по дате"))
                {
                    meetList.Items.Add("Тип: " + s[1]);
                    meetList.Items.Add("Статус: " + s[2]);
                    meetList.Items.Add("Дата и время: " + s[3]);
                    meetList.Items.Add("Место: " + s[4]);
                    meetList.Items.Add("______________________________________________________");
                }
            }
            if (meetList.Items.Count == 0)
            {
                meetList.Items.Add("Ничего не найдено");
            }
            SqlUse.connection.Close();
            reader.Close();
        }
        private void MeetTime_ValueChanged(object sender, EventArgs e)
        {
            meetSearch.Text = "Поиск по дате";
            string command = "SELECT * FROM [Встречи]";
            string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Встречи'";
            MeetList_AddValue(command, lastIdCheck);
        }
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void PingSearch_Click(object sender, EventArgs e)
        {
            SqlFunctions.UserPing();
        }

        private void UserMain_Load(object sender, EventArgs e)
        {
            meetTime.CalendarTitleBackColor = Color.Red;
            meetSearch.Text = "Поиск по дате";
            string command = "SELECT * FROM [Встречи]";
            string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Встречи'";
            MeetList_AddValue(command, lastIdCheck);
            SqlUse.connection.Open();
            string commandStatusTypeAdd = "SELECT idMeet From Встречи";
            SqlCommand query = new SqlCommand(commandStatusTypeAdd, SqlUse.connection);
            SqlDataReader reader = query.ExecuteReader();
            meetSearch.Items.Add("Поиск по дате");
            while (reader.Read())
            {
                if (reader[0].ToString() != "") meetSearch.Items.Add(reader[0].ToString());
            }
            reader.Close();
            SqlUse.connection.Close();
        }

        private void MeetSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (meetSearch.SelectedIndex == 0)
            {
                string command = "SELECT * FROM [Встречи]";
                string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Встречи'";
                MeetList_AddValue(command, lastIdCheck);
            }
            else 
            {
                string command = "SELECT * FROM [Встречи] WHERE idMeet = " + meetSearch.Text;
                string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Встречи'";
                MeetList_AddValue(command, lastIdCheck);
            }
        }
    }
}
