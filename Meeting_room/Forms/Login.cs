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
using System.Configuration;
using Meeting;

namespace Meeting_room
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void Connect()
        {

        }
        public int Test(string A, string B)
        {
            SqlConnection conn = new SqlConnection(User.connectionLine[1].ToString());
            conn.Open();
            string sql = "SELECT * FROM [meeting_db].[dbo].[Аккаунты]";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            int ADMtest = 0;
            while (reader.Read())
            {
                if (A == reader[1].ToString() && B == reader[2].ToString())
                {
                    ADMtest = Convert.ToInt32(reader[3]);
                }
            }
            reader.Close();
            conn.Close();
            return (ADMtest);
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(User.connectionLine[1].ToString());
            connection.Open();
            string command = "SELECT * FROM [meeting_db].[dbo].[Аккаунты]";
            SqlCommand query = new SqlCommand(command, connection);
            SqlDataReader reader = query.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();
            foreach (string[] s in data)
            {
                if (LoginName.Text == s[1])
                {
                    if (LoginPass.Text == s[2])
                    {
                        Int32.TryParse(s[0], out int idAccount);
                        Int32.TryParse(s[3], out int idRole);
                        if (s[3] == "1")
                        {
                            User.Ping = Convert.ToInt32(idAccount);
                            User.Role = Convert.ToInt32(idRole);
                            MessageBox.Show("Вы вошли как администратор");
                            this.Hide();
                            AdminMain adminMain = new AdminMain();
                            adminMain.Show();
                        }
                        if (s[3] == "2")
                        {
                            User.Ping = Convert.ToInt32(s[idAccount]);
                            MessageBox.Show("Вы успешно вошли");
                            this.Hide();
                            UserMain userMain = new UserMain();
                            userMain.Show();
                        }
                        if (s[3] == "3")
                        {
                            User.Ping = Convert.ToInt32(s[idAccount]);
                            MessageBox.Show("Вы вошли как инициатор");
                            this.Hide();
                            OrganizerMain organizerMain = new OrganizerMain();
                            organizerMain.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильный пароль");
                    }
                }
            }
            connection.Close();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            bool testUserCount = false;
            SqlConnection connection = new SqlConnection(User.connectionLine[1].ToString());
            connection.Open();
            string loginCount = "SELECT [Логин] FROM [dbo].[Аккаунты] WHERE Логин LIKE ('" + registrationName.Text + "')";
            SqlCommand countCommand = new SqlCommand(loginCount, connection);
            SqlDataReader reader = countCommand.ExecuteReader();
            string lastId = "SELECT COUNT(idAccount) From Аккаунты";
            int id = SqlFunctions.LastIdCheck(lastId);
            if (reader.HasRows == true)
            {
                testUserCount = true;
            }
            reader.Close();
            if (testUserCount == false)
            {
                string command = "INSERT INTO [meeting_db].[dbo].[Аккаунты](idAccount, Логин, Пароль, idRole) VALUES ('" +
                        (id+1) + "', '" + registrationName.Text + "', '" + registrationPass.Text + "', '2')";
                SqlCommand query = new SqlCommand(command, connection);
                query.ExecuteNonQuery();
                MessageBox.Show("Вы успешно зарегестрироваллись");
            }
            else
            {
                MessageBox.Show("Данный пользователь уже существует");
            }
            connection.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void LoginPass_Enter(object sender, EventArgs e)
        {
            LoginButton_Click(sender, e);
        }
    }
}
