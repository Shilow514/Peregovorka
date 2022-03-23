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

namespace Переговорка
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        public string connection = "Data Source=PIT29\\SHILOV;Initial Catalog=meeting_db;User ID=sa;Password=123";
        public string viewTableCommandNow;
        public string viewTableUpdate;
        public string viewIdNow;
        public bool isAdmin;
        public void ViewFunction(string command, string lastIdCheck, string getTableName)
        {
            deletedLineNumber.Items.Clear();
            int i;
            resultView.Rows.Clear();
            resultView.Columns.Clear();
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
                for (i = 0; i < lastId; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
                deletedLineNumber.Items.Add(reader[0].ToString());
            }
            reader.Close();
            SqlCommand getName = new SqlCommand(getTableName, sqlConnection);
            reader = getName.ExecuteReader();
            i = 0;
            while (reader.Read())
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                this.resultView.Columns.Add(column);
                resultView.Columns[i].HeaderText = reader[0].ToString();
                i++;
            }
            reader.Close();
            foreach (string[] s in data)
            {
                resultView.Rows.Add(s);
            }
            sqlConnection.Close();
        }
        public int lastIdCheck(string lastIdCheck)
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
            SqlCommand sqlLastIdCheck = new SqlCommand(lastIdCheck, sqlConnection);
            SqlDataReader readerId = sqlLastIdCheck.ExecuteReader();
            readerId.Read();
            int lastId = Convert.ToInt32(readerId[0]);
            readerId.Close();
            sqlConnection.Close();
            return (lastId);
        }
        public void addFunction(string command)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(connection);
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

        private void addType_Click(object sender, EventArgs e)
        {
            string lastIdCommand = "SELECT COUNT(*) as count FROM [Тип встречи]";
            int lastId = lastIdCheck(lastIdCommand);
            string command = "INSERT INTO [Тип встречи](idType, [Тип встречи]) VALUES (" + (lastId + 1) + ",'" + typeText.Text + "')";
            addFunction(command);
            MessageBox.Show("Тип успешно добавлен");
        }

        private void addStatus_Click(object sender, EventArgs e)
        {
            string lastIdCommand = "SELECT COUNT(*) as count FROM [Статус встречи]";
            int lastId = lastIdCheck(lastIdCommand);
            string command = "INSERT INTO [Тип встречи](idType, [Статус встречи]) VALUES (" + (lastId + 1) + ",'" + statusText.Text + "')";
            addFunction(command);
            MessageBox.Show("Тип успешно добавлен");
        }

        private void roleChoose_CheckedChanged(object sender, EventArgs e)
        {
            string command = "SELECT * FROM [Роли]";
            string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Роли'";
            string getTableName = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Роли'";
            viewTableCommandNow = " [Роли] WHERE idRole";
            viewTableUpdate = "UPDATE  [Роли] set idRole = idRole-1 Where idRole > ";
            viewIdNow = "idRole";
            ViewFunction(command, lastIdCheck, getTableName);
        }

        private void meetChoose_CheckedChanged(object sender, EventArgs e)
        {
            string command = "SELECT * FROM [Встречи]";
            string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Встречи'";
            string getTableName = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Встречи'";
            viewTableCommandNow = " [Встречи] WHERE idMeet";
            viewTableUpdate = "UPDATE  [Встречи] set idMeet = idMeet-1 Where idMeet >";
            viewIdNow = "idMeet";
            ViewFunction(command, lastIdCheck, getTableName);
        }

        private void statusChoose_CheckedChanged(object sender, EventArgs e)
        {
            string command = "SELECT * FROM [Статус Встречи]";
            string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Статус Встречи'";
            string getTableName = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Статус Встречи'";
            viewTableCommandNow = " [Статус Встречи] WHERE idStatus";
            viewTableUpdate = "UPDATE  [Статус Встречи] set idStatus = idStatus-1 Where idStatus > ";
            viewIdNow = "idStatus";
            ViewFunction(command, lastIdCheck, getTableName);
        }

        private void typeChoose_CheckedChanged(object sender, EventArgs e)
        {
            string command = "SELECT * FROM [Тип Встречи]";
            string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Тип Встречи'";
            string getTableName = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Тип Встречи'";
            viewTableCommandNow = "[Тип Встречи] WHERE idType";
            viewTableUpdate = "UPDATE  [Тип Встречи] set idType = idType-1 Where idType > ";
            viewIdNow = "idType";
            ViewFunction(command, lastIdCheck, getTableName);
        }
        private void accountChoose_CheckedChanged(object sender, EventArgs e)
        {
            string command = "SELECT * FROM [Аккаунты]";
            string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Аккаунты'";
            string getTableName = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Аккаунты'";
            viewTableCommandNow = "[Аккаунты] WHERE not idRole = 1 and idAccount ";
            viewTableUpdate = "UPDATE  [Аккаунты] set idAccount = idAccount-1 Where idAccount > ";
            viewIdNow = "idAccount";
            ViewFunction(command, lastIdCheck, getTableName);
        }
        private void eraseLine_Click(object sender, EventArgs e)
        {
            if (accountChoose.Checked != true || deletedLineNumber.Text != User.ping.ToString())
            {
                string message = "Вы уверены, что хотите удалить строчку?";
                string caption = "Удалить строчку";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    string command = "DELETE FROM " + viewTableCommandNow + " = '" + Convert.ToInt32(deletedLineNumber.Text) + "'";
                    addFunction(command);
                    command = viewTableUpdate + Convert.ToInt32(deletedLineNumber.Text);
                    addFunction(command);
                    if (meetChoose.Checked == true)
                    {
                        command = "DELETE FROM Уведомления WHERE idMeet = " + deletedLineNumber.Text + " " +
                            "DECLARE @DeletedLines INT " +
                            "SET @DeletedLines = @@ROWCOUNT " +
                            "UPDATE[Уведомления] set idPing = idPing - @DeletedLines Where idMeet > " + deletedLineNumber.Text +
                            "UPDATE  [Уведомления] set idMeet = idMeet-1 Where idMeet > " + deletedLineNumber.Text;
                        addFunction(command);
                        meetChoose_CheckedChanged(sender, e);
                    }
                    if (statusChoose.Checked == true) statusChoose_CheckedChanged(sender, e);
                    if (typeChoose.Checked == true) typeChoose_CheckedChanged(sender, e);
                    if (roleChooose.Checked == true) roleChoose_CheckedChanged(sender, e);
                    if (accountChoose.Checked == true) accountChoose_CheckedChanged(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Вы не можете удалить себя");
            }
        }
    }
}
