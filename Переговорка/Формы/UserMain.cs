﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Переговорка
{
    public partial class UserMain : Form
    {
        public UserMain()
        {
            InitializeComponent();
        }
        public string connection = "Data Source=PIT29\\SHILOV;Initial Catalog=meeting_db;User ID=sa;Password=123";
        private void userPing()
        {
            string messageList = "";
            string connectionLine = "Data Source=PIT29\\SHILOV;Initial Catalog=meeting_db;User ID=sa;Password=123";
            SqlConnection connection = new SqlConnection(connectionLine);
            connection.Open();
            string command = "SELECT * FROM Уведомления";
            SqlCommand query = new SqlCommand(command, connection);
            SqlDataReader reader = query.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            foreach(string[] s in data)
            {
                if (Convert.ToInt32(s[1]) == User.ping)
                {
                    messageList += "Вас ожидают в комнате " + s[2] + "\n";
                }
            }
            MessageBox.Show(messageList);
        }
        private void meetList_AddValue(string command, string lastIdCheck)
        {
            meetList.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            SqlCommand sqlLastIdCheck = new SqlCommand(lastIdCheck, sqlConnection);
            SqlDataReader readerId = sqlLastIdCheck.ExecuteReader();
            readerId.Read();
            int lastId = Convert.ToInt32(readerId[0]);
            readerId.Close();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
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
            sqlConnection.Close();
            reader.Close();
        }
        private void meetTime_ValueChanged(object sender, EventArgs e)
        {
            meetSearch.Text = "Поиск по дате";
            string command = "SELECT * FROM [Встречи]";
            string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Встречи'";
            meetList_AddValue(command, lastIdCheck);
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void pingSearch_Click(object sender, EventArgs e)
        {
            userPing();
        }

        private void UserMain_Load(object sender, EventArgs e)
        {
            meetTime.CalendarTitleBackColor = Color.Red;
            meetSearch.Text = "Поиск по дате";
            string command = "SELECT * FROM [Встречи]";
            string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Встречи'";
            meetList_AddValue(command, lastIdCheck);
            string connectionLine = "Data Source=PIT29\\SHILOV;Initial Catalog=meeting_db;User ID=sa;Password=123";
            SqlConnection connection = new SqlConnection(connectionLine);
            connection.Open();
            string commandStatusTypeAdd = "SELECT idMeet From Встречи";
            SqlCommand query = new SqlCommand(commandStatusTypeAdd, connection);
            SqlDataReader reader = query.ExecuteReader();
            meetSearch.Items.Add("Поиск по дате");
            while (reader.Read())
            {
                if (reader[0].ToString() != "") meetSearch.Items.Add(reader[0].ToString());
            }
            reader.Close();
            connection.Close();
        }

        private void meetSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (meetSearch.SelectedIndex == 0)
            {
                string command = "SELECT * FROM [Встречи]";
                string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Встречи'";
                meetList_AddValue(command, lastIdCheck);
            }
            else 
            {
                string command = "SELECT * FROM [Встречи] WHERE idMeet = " + meetSearch.Text;
                string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Встречи'";
                meetList_AddValue(command, lastIdCheck);
            }
        }
    }
}
