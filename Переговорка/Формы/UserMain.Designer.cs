
namespace Переговорка
{
    partial class UserMain
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
            this.meetTime = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.meetList = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.meetSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pingSearch = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // meetTime
            // 
            this.meetTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.meetTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.meetTime.Location = new System.Drawing.Point(216, 5);
            this.meetTime.MaximumSize = new System.Drawing.Size(136, 20);
            this.meetTime.MinimumSize = new System.Drawing.Size(136, 20);
            this.meetTime.Name = "meetTime";
            this.meetTime.Size = new System.Drawing.Size(136, 20);
            this.meetTime.TabIndex = 0;
            this.meetTime.ValueChanged += new System.EventHandler(this.meetTime_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.meetTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(216, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(564, 30);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.meetList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 40);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(564, 400);
            this.panel1.TabIndex = 4;
            // 
            // meetList
            // 
            this.meetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meetList.FormattingEnabled = true;
            this.meetList.Location = new System.Drawing.Point(10, 10);
            this.meetList.Name = "meetList";
            this.meetList.Size = new System.Drawing.Size(544, 380);
            this.meetList.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 440);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(564, 110);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.meetSearch);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 100);
            this.panel5.TabIndex = 3;
            // 
            // meetSearch
            // 
            this.meetSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.meetSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.meetSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.meetSearch.Location = new System.Drawing.Point(0, 13);
            this.meetSearch.Name = "meetSearch";
            this.meetSearch.Size = new System.Drawing.Size(150, 21);
            this.meetSearch.TabIndex = 0;
            this.meetSearch.SelectedIndexChanged += new System.EventHandler(this.meetSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск по комнате";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pingSearch);
            this.panel4.Controls.Add(this.buttonBack);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(409, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 100);
            this.panel4.TabIndex = 2;
            // 
            // pingSearch
            // 
            this.pingSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pingSearch.Location = new System.Drawing.Point(0, 0);
            this.pingSearch.MaximumSize = new System.Drawing.Size(150, 30);
            this.pingSearch.MinimumSize = new System.Drawing.Size(100, 30);
            this.pingSearch.Name = "pingSearch";
            this.pingSearch.Size = new System.Drawing.Size(150, 30);
            this.pingSearch.TabIndex = 1;
            this.pingSearch.Text = "Место встречи";
            this.pingSearch.UseVisualStyleBackColor = true;
            this.pingSearch.Click += new System.EventHandler(this.pingSearch_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonBack.Location = new System.Drawing.Point(0, 70);
            this.buttonBack.MaximumSize = new System.Drawing.Size(150, 30);
            this.buttonBack.MinimumSize = new System.Drawing.Size(100, 30);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 30);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "UserMain";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker meetTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox meetList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button pingSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox meetSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
    }
}