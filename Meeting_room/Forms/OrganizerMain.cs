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

namespace Meeting_room
{
    public partial class OrganizerMain : Form
    {
        int id;
        public OrganizerMain()
        {
            InitializeComponent();
            OrganizerMain_load();
        }
        public void OrganizerMain_load()
        {
            SqlConnection connection = new SqlConnection(User.connectionLine[1].ToString());
            connection.Open();
            string commandStatusTypeAdd = "SELECT [Статус встречи],[Тип встречи] FROM [Статус встречи] FULL OUTER JOIN [Тип встречи] ON idStatus = idType";
            SqlCommand query = new SqlCommand(commandStatusTypeAdd, connection);
            SqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() != "") selectStatus.Items.Add(reader[0].ToString());
                if (reader[1].ToString() != "") selectType.Items.Add(reader[1].ToString());
            }
            reader.Close();
            connection.Close();
        }

        private void AddPlace_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(User.connectionLine[1].ToString());
            connection.Open();
            string commandIdCheck = "SELECT COUNT(*) as count FROM dbo.Встречи";
            SqlCommand lastId = new SqlCommand(commandIdCheck, connection);
            SqlDataReader reader = lastId.ExecuteReader();
            reader.Read();
            Int32.TryParse(reader[0].ToString(), out int value);
            string command = "INSERT INTO [meeting_db].[dbo].[Встречи](idMeet, [Тип встречи], [Статус встречи], Дата, Место) " +
                "VALUES ('" + (value + 1) + "', '" + selectType.Text + "', '" + selectStatus.Text +
                "', '" + date.Value + "', '" + place.Text + "')";
            SqlCommand query = new SqlCommand(command, connection);
            id = Convert.ToInt32(reader[0]) + 1;
            reader.Close();
            query.ExecuteNonQuery();
            connection.Close();
            sendPing.Enabled = true;
            userName.Enabled = true;
            MessageBox.Show("Встреча успешно добавлена");
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void SendPing_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(User.connectionLine[1].ToString());
            connection.Open();
            string commandName = "SELECT idAccount FROM Аккаунты WHERE Логин LIKE('" + userName.Text + "')";
            string commandIdCheck = "SELECT COUNT(*) as count FROM Уведомления";
            SqlCommand lastId = new SqlCommand(commandIdCheck, connection);
            SqlCommand setName = new SqlCommand(commandName, connection);
            SqlDataReader idReader = lastId.ExecuteReader();
            idReader.Read();
            int idRead = Convert.ToInt32(idReader[0]) + 1;
            idReader.Close();
            SqlDataReader nameReader = setName.ExecuteReader();
            nameReader.Read();
            if (nameReader.HasRows)
            {
                string command = "INSERT INTO Уведомления(idPing, idAccount, idMeet) VALUES (" + idRead + " ," + Convert.ToInt32(nameReader[0]) + " ," + id + ")";
                SqlCommand sqlCommand = new SqlCommand(command, connection);
                nameReader.Close();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Вы уведомили пользователя");
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
            nameReader.Close();
            connection.Close();
        }
    }
}
