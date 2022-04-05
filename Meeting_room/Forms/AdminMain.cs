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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private string viewTableCommandNow;
        private string viewTableUpdate;

        private void AddType_Click(object sender, EventArgs e)
        {
            string lastIdCommand = "SELECT COUNT(*) as count FROM [Тип встречи]";
            int lastId = SqlFunctions.LastIdCheck(lastIdCommand);
            string command = "INSERT INTO [Тип встречи](idType, [Тип встречи]) VALUES (" + (lastId + 1) + ",'" + typeText.Text + "')";
            SqlFunctions.AddFunction(command);
            MessageBox.Show("Тип успешно добавлен");
        }

        private void AddStatus_Click(object sender, EventArgs e)
        {
            string lastIdCommand = "SELECT COUNT(*) as count FROM [Статус встречи]";
            int lastId = SqlFunctions.LastIdCheck(lastIdCommand);
            string command = "INSERT INTO [Статус встречи](idStatus, [Статус встречи]) VALUES (" + (lastId + 1) + ",'" + statusText.Text + "')";
            SqlFunctions.AddFunction(command);
            MessageBox.Show("Статус успешно добавлен");
        }

        private void RoleChoose_CheckedChanged(object sender, EventArgs e)
        {
            string command = "SELECT * FROM [Роли]";
            string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Роли'";
            string getTableName = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Роли'";
            viewTableCommandNow = " [Роли] WHERE idRole";
            viewTableUpdate = "UPDATE  [Роли] set idRole = idRole-1 Where idRole > ";
            deletedLineNumber = SqlFunctions.AddToComboBox(command, lastIdCheck, deletedLineNumber);
            resultView = SqlFunctions.AddToGrid(command, lastIdCheck, getTableName, resultView);
        }

        private void MeetChoose_CheckedChanged(object sender, EventArgs e)
        {
            string command = "SELECT * FROM [Встречи]";
            string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Встречи'";
            string getTableName = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Встречи'";
            viewTableCommandNow = " [Встречи] WHERE idMeet";
            viewTableUpdate = "UPDATE  [Встречи] set idMeet = idMeet-1 Where idMeet >";
            deletedLineNumber = SqlFunctions.AddToComboBox(command, lastIdCheck, deletedLineNumber);
            resultView = SqlFunctions.AddToGrid(command, lastIdCheck, getTableName, resultView);
        }

        private void StatusChoose_CheckedChanged(object sender, EventArgs e)
        {
            string command = "SELECT * FROM [Статус Встречи]";
            string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Статус Встречи'";
            string getTableName = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Статус Встречи'";
            viewTableCommandNow = " [Статус Встречи] WHERE idStatus";
            viewTableUpdate = "UPDATE  [Статус Встречи] set idStatus = idStatus-1 Where idStatus > ";
            deletedLineNumber = SqlFunctions.AddToComboBox(command, lastIdCheck, deletedLineNumber);
            resultView = SqlFunctions.AddToGrid(command, lastIdCheck, getTableName, resultView);
        }

        private void TypeChoose_CheckedChanged(object sender, EventArgs e)
        {
            string command = "SELECT * FROM [Тип Встречи]";
            string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Тип Встречи'";
            string getTableName = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Тип Встречи'";
            viewTableCommandNow = "[Тип Встречи] WHERE idType";
            viewTableUpdate = "UPDATE  [Тип Встречи] set idType = idType-1 Where idType > ";
            deletedLineNumber = SqlFunctions.AddToComboBox(command, lastIdCheck, deletedLineNumber);
            resultView = SqlFunctions.AddToGrid(command, lastIdCheck, getTableName, resultView);
        }
        private void AccountChoose_CheckedChanged(object sender, EventArgs e)
        {
            string command = "SELECT * FROM [Аккаунты]";
            string lastIdCheck = "SELECT COUNT(*)FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Аккаунты'";
            string getTableName = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Аккаунты'";
            viewTableCommandNow = "[Аккаунты] WHERE not idRole = 1 and idAccount ";
            viewTableUpdate = "UPDATE  [Аккаунты] set idAccount = idAccount-1 Where idAccount > ";
            deletedLineNumber = SqlFunctions.AddToComboBox(command, lastIdCheck, deletedLineNumber);
            resultView = SqlFunctions.AddToGrid(command, lastIdCheck, getTableName, resultView);
        }
        private void EraseLine_Click(object sender, EventArgs e)
        {
            if (accountChoose.Checked != true || deletedLineNumber.Text != User.Ping.ToString())
            {
                string message = "Вы уверены, что хотите удалить строчку?";
                string caption = "Удалить строчку";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Int32.TryParse(deletedLineNumber.Text, out int value))
                    {
                        string command = "DELETE FROM " + viewTableCommandNow + " = '" + value + "'";
                        SqlFunctions.AddFunction(command);
                        command = viewTableUpdate + value;
                        SqlFunctions.AddFunction(command);
                        if (meetChoose.Checked == true)
                        {
                            command = "DELETE FROM Уведомления WHERE idMeet = " + deletedLineNumber.Text + " " +
                                "DECLARE @DeletedLines INT " +
                                "SET @DeletedLines = @@ROWCOUNT " +
                                "UPDATE[Уведомления] set idPing = idPing - @DeletedLines Where idMeet > " + deletedLineNumber.Text +
                                "UPDATE  [Уведомления] set idMeet = idMeet-1 Where idMeet > " + deletedLineNumber.Text;
                            SqlFunctions.AddFunction(command);
                            MeetChoose_CheckedChanged(sender, e);
                        }
                        if (statusChoose.Checked == true) StatusChoose_CheckedChanged(sender, e);
                        if (typeChoose.Checked == true) TypeChoose_CheckedChanged(sender, e);
                        if (roleChooose.Checked == true) RoleChoose_CheckedChanged(sender, e);
                        if (accountChoose.Checked == true) AccountChoose_CheckedChanged(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не можете удалить себя");
            }
        }
    }
}
