using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Meeting_room;
using System.Windows.Forms;

namespace Meeting
{
    public static class SqlFunctions
    {
        public static int LastIdCheck(string lastIdCheck)
        {
            SqlUse.connection.Open();
            SqlCommand sqlLastIdCheck = new SqlCommand(lastIdCheck, SqlUse.connection);
            SqlDataReader readerId = sqlLastIdCheck.ExecuteReader();
            readerId.Read();
            int lastId = Convert.ToInt32(readerId[0]);
            readerId.Close();
            SqlUse.connection.Close();
            return (lastId);
        }
        public static void AddFunction(string command)
        {
            try
            {
                SqlUse.connection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, SqlUse.connection);
                sqlCommand.ExecuteNonQuery();
                SqlUse.connection.Close();
            }
            catch
            {
                MessageBox.Show("Попытка удалить администратора");
                SqlUse.connection.Close();
            }
        }
        public static ComboBox AddToComboBox(string command, string lastIdCheck, ComboBox deletedLineNumber)
        {
            deletedLineNumber.Items.Clear();
            SqlUse.connection.Open();
            SqlCommand sqlLastIdCheck = new SqlCommand(lastIdCheck, SqlUse.connection);
            SqlDataReader readerId = sqlLastIdCheck.ExecuteReader();
            readerId.Read();
            int lastId = Convert.ToInt32(readerId[0]);
            readerId.Close();
            SqlCommand sqlCommand = new SqlCommand(command, SqlUse.connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<string[]> data = new List<string[]>();
            int i;
            while (reader.Read())
            {
                data.Add(new string[lastId]);
                for (i = 0; i < lastId; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
                deletedLineNumber.Items.Add(reader[0].ToString());
            }
            reader.Close();
            SqlUse.connection.Close();
            return (deletedLineNumber);
        }
        public static DataGridView AddToGrid(string command, string lastIdCheck, string getTableName, DataGridView resultView)
        {
            resultView.Rows.Clear();
            resultView.Columns.Clear();
            SqlUse.connection.Open();
            SqlCommand sqlLastIdCheck = new SqlCommand(lastIdCheck, SqlUse.connection);
            SqlDataReader readerId = sqlLastIdCheck.ExecuteReader();
            readerId.Read();
            int lastId = Convert.ToInt32(readerId[0]);
            readerId.Close();
            SqlCommand sqlCommand = new SqlCommand(command, SqlUse.connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<string[]> data = new List<string[]>();
            int i;
            while (reader.Read())
            {
                data.Add(new string[lastId]);
                for (i = 0; i < lastId; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            SqlCommand getName = new SqlCommand(getTableName, SqlUse.connection);
            reader = getName.ExecuteReader();
            i = 0;
            while (reader.Read())
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                resultView.Columns.Add(column);
                resultView.Columns[i].HeaderText = reader[0].ToString();
                i++;
            }
            reader.Close();
            foreach (string[] s in data)
            {
                resultView.Rows.Add(s);
            }
            SqlUse.connection.Close();
            return (resultView);
        }
        public static void UserPing()
        {
            string messageList = "";
            SqlUse.connection.Open();
            string command = "SELECT * FROM Уведомления";
            SqlCommand query = new SqlCommand(command, SqlUse.connection);
            SqlDataReader reader = query.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            foreach (string[] s in data)
            {
                if (Convert.ToInt32(s[1]) == User.Ping)
                {
                    messageList += "Вас ожидают в комнате " + s[2] + "\n";
                }
            }
            SqlUse.connection.Close();
            MessageBox.Show(messageList);
        }
    }
}
