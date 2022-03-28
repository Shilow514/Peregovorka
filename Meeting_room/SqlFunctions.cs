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
            SqlConnection sqlConnection = new SqlConnection(User.connectionLine[1].ToString());
            sqlConnection.Open();
            SqlCommand sqlLastIdCheck = new SqlCommand(lastIdCheck, sqlConnection);
            SqlDataReader readerId = sqlLastIdCheck.ExecuteReader();
            readerId.Read();
            int lastId = Convert.ToInt32(readerId[0]);
            readerId.Close();
            sqlConnection.Close();
            return (lastId);
        }
        public static void AddFunction(string command)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(User.connectionLine[1].ToString());
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Попытка удалить администратора");
            }
        }
        public static ComboBox AddToComboBox(string command, string lastIdCheck, ComboBox deletedLineNumber)
        {
            deletedLineNumber.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection(User.connectionLine[1].ToString());
            sqlConnection.Open();
            SqlCommand sqlLastIdCheck = new SqlCommand(lastIdCheck, sqlConnection);
            SqlDataReader readerId = sqlLastIdCheck.ExecuteReader();
            readerId.Read();
            int lastId = Convert.ToInt32(readerId[0]);
            readerId.Close();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
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
            sqlConnection.Close();
            return (deletedLineNumber);
        }
        public static DataGridView AddToGrid(string command, string lastIdCheck, string getTableName, DataGridView resultView)
        {
            resultView.Rows.Clear();
            resultView.Columns.Clear();
            SqlConnection sqlConnection = new SqlConnection(User.connectionLine[1].ToString());
            sqlConnection.Open();
            SqlCommand sqlLastIdCheck = new SqlCommand(lastIdCheck, sqlConnection);
            SqlDataReader readerId = sqlLastIdCheck.ExecuteReader();
            readerId.Read();
            int lastId = Convert.ToInt32(readerId[0]);
            readerId.Close();
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
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
            SqlCommand getName = new SqlCommand(getTableName, sqlConnection);
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
            sqlConnection.Close();
            return (resultView);
        }
    }
}
