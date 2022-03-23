
namespace Переговорка
{
    partial class OrganizerMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.selectStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.userName = new System.Windows.Forms.TextBox();
            this.sendPing = new System.Windows.Forms.Button();
            this.addMeet = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.place = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(130, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Статус";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.selectStatus);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(2, 40);
            this.panel9.Margin = new System.Windows.Forms.Padding(5);
            this.panel9.MaximumSize = new System.Drawing.Size(200, 25);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(171, 25);
            this.panel9.TabIndex = 1;
            // 
            // selectStatus
            // 
            this.selectStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectStatus.FormattingEnabled = true;
            this.selectStatus.Location = new System.Drawing.Point(0, 0);
            this.selectStatus.Name = "selectStatus";
            this.selectStatus.Size = new System.Drawing.Size(171, 21);
            this.selectStatus.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(138, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Дата";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(2, 65);
            this.panel8.Margin = new System.Windows.Forms.Padding(5);
            this.panel8.MaximumSize = new System.Drawing.Size(200, 25);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(171, 25);
            this.panel8.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.date);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(2, 90);
            this.panel7.Margin = new System.Windows.Forms.Padding(5);
            this.panel7.MaximumSize = new System.Drawing.Size(200, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(171, 25);
            this.panel7.TabIndex = 3;
            // 
            // date
            // 
            this.date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(171, 20);
            this.date.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.sendPing);
            this.groupBox3.Controls.Add(this.addMeet);
            this.groupBox3.Controls.Add(this.buttonBack);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Controls.Add(this.panel8);
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Controls.Add(this.panel10);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(25, 38);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(175, 393);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(2, 272);
            this.panel6.Margin = new System.Windows.Forms.Padding(5);
            this.panel6.MaximumSize = new System.Drawing.Size(200, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(171, 25);
            this.panel6.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(72, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Логин сотрудника";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.userName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(2, 297);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.MaximumSize = new System.Drawing.Size(200, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 25);
            this.panel5.TabIndex = 11;
            // 
            // userName
            // 
            this.userName.Dock = System.Windows.Forms.DockStyle.Top;
            this.userName.Enabled = false;
            this.userName.Location = new System.Drawing.Point(0, 0);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(171, 20);
            this.userName.TabIndex = 0;
            // 
            // sendPing
            // 
            this.sendPing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendPing.Enabled = false;
            this.sendPing.Location = new System.Drawing.Point(2, 322);
            this.sendPing.Margin = new System.Windows.Forms.Padding(0);
            this.sendPing.Name = "sendPing";
            this.sendPing.Size = new System.Drawing.Size(171, 23);
            this.sendPing.TabIndex = 10;
            this.sendPing.Text = "Уведомить";
            this.sendPing.UseVisualStyleBackColor = true;
            this.sendPing.Click += new System.EventHandler(this.sendPing_Click);
            // 
            // addMeet
            // 
            this.addMeet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addMeet.Location = new System.Drawing.Point(2, 345);
            this.addMeet.Margin = new System.Windows.Forms.Padding(0);
            this.addMeet.Name = "addMeet";
            this.addMeet.Size = new System.Drawing.Size(171, 23);
            this.addMeet.TabIndex = 9;
            this.addMeet.Text = "Добавить";
            this.addMeet.UseVisualStyleBackColor = true;
            this.addMeet.Click += new System.EventHandler(this.addPlace_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonBack.Location = new System.Drawing.Point(2, 368);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(171, 23);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.place);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 190);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.MaximumSize = new System.Drawing.Size(200, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 25);
            this.panel3.TabIndex = 7;
            // 
            // place
            // 
            this.place.Dock = System.Windows.Forms.DockStyle.Top;
            this.place.Location = new System.Drawing.Point(0, 0);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(171, 20);
            this.place.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(2, 165);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.MaximumSize = new System.Drawing.Size(200, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(171, 25);
            this.panel4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(88, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Место/Ссылка";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 140);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.MaximumSize = new System.Drawing.Size(200, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 25);
            this.panel1.TabIndex = 5;
            // 
            // selectType
            // 
            this.selectType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectType.FormattingEnabled = true;
            this.selectType.Location = new System.Drawing.Point(0, 0);
            this.selectType.Name = "selectType";
            this.selectType.Size = new System.Drawing.Size(171, 21);
            this.selectType.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.MaximumSize = new System.Drawing.Size(200, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 25);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(145, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(2, 15);
            this.panel10.Margin = new System.Windows.Forms.Padding(5);
            this.panel10.MaximumSize = new System.Drawing.Size(200, 25);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(171, 25);
            this.panel10.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(4, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(25);
            this.groupBox2.Size = new System.Drawing.Size(225, 456);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // OrganizerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(234, 461);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(250, 500);
            this.MinimumSize = new System.Drawing.Size(250, 500);
            this.Name = "OrganizerMain";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Text = "OrganizerMain";
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button addMeet;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox place;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectStatus;
        private System.Windows.Forms.ComboBox selectType;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button sendPing;
    }
}