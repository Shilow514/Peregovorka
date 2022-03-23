
namespace Переговорка
{
    partial class AdminMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.accountChoose = new System.Windows.Forms.RadioButton();
            this.roleChooose = new System.Windows.Forms.RadioButton();
            this.statusChoose = new System.Windows.Forms.RadioButton();
            this.typeChoose = new System.Windows.Forms.RadioButton();
            this.meetChoose = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.statusText = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.addStatus = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.typeText = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.addType = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultView = new System.Windows.Forms.DataGridView();
            this.panel18 = new System.Windows.Forms.Panel();
            this.eraseLine = new System.Windows.Forms.Button();
            this.deletedLineNumber = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.MaximumSize = new System.Drawing.Size(560, 200);
            this.panel1.MinimumSize = new System.Drawing.Size(560, 200);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(560, 200);
            this.panel1.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel7);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(210, 10);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(10);
            this.panel13.Size = new System.Drawing.Size(140, 180);
            this.panel13.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.accountChoose);
            this.panel7.Controls.Add(this.roleChooose);
            this.panel7.Controls.Add(this.statusChoose);
            this.panel7.Controls.Add(this.typeChoose);
            this.panel7.Controls.Add(this.meetChoose);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(10, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(120, 160);
            this.panel7.TabIndex = 0;
            // 
            // accountChoose
            // 
            this.accountChoose.AutoSize = true;
            this.accountChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountChoose.Location = new System.Drawing.Point(0, 116);
            this.accountChoose.Name = "accountChoose";
            this.accountChoose.Padding = new System.Windows.Forms.Padding(6);
            this.accountChoose.Size = new System.Drawing.Size(120, 29);
            this.accountChoose.TabIndex = 9;
            this.accountChoose.TabStop = true;
            this.accountChoose.Text = "Аккаунты";
            this.accountChoose.UseVisualStyleBackColor = true;
            this.accountChoose.CheckedChanged += new System.EventHandler(this.accountChoose_CheckedChanged);
            // 
            // roleChooose
            // 
            this.roleChooose.AutoSize = true;
            this.roleChooose.Dock = System.Windows.Forms.DockStyle.Top;
            this.roleChooose.Location = new System.Drawing.Point(0, 87);
            this.roleChooose.Name = "roleChooose";
            this.roleChooose.Padding = new System.Windows.Forms.Padding(6);
            this.roleChooose.Size = new System.Drawing.Size(120, 29);
            this.roleChooose.TabIndex = 5;
            this.roleChooose.TabStop = true;
            this.roleChooose.Text = "Роли";
            this.roleChooose.UseVisualStyleBackColor = true;
            this.roleChooose.CheckedChanged += new System.EventHandler(this.roleChoose_CheckedChanged);
            // 
            // statusChoose
            // 
            this.statusChoose.AutoSize = true;
            this.statusChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusChoose.Location = new System.Drawing.Point(0, 58);
            this.statusChoose.Name = "statusChoose";
            this.statusChoose.Padding = new System.Windows.Forms.Padding(6);
            this.statusChoose.Size = new System.Drawing.Size(120, 29);
            this.statusChoose.TabIndex = 7;
            this.statusChoose.TabStop = true;
            this.statusChoose.Text = "Статусы";
            this.statusChoose.UseVisualStyleBackColor = true;
            this.statusChoose.CheckedChanged += new System.EventHandler(this.statusChoose_CheckedChanged);
            // 
            // typeChoose
            // 
            this.typeChoose.AutoSize = true;
            this.typeChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.typeChoose.Location = new System.Drawing.Point(0, 29);
            this.typeChoose.Name = "typeChoose";
            this.typeChoose.Padding = new System.Windows.Forms.Padding(6);
            this.typeChoose.Size = new System.Drawing.Size(120, 29);
            this.typeChoose.TabIndex = 8;
            this.typeChoose.TabStop = true;
            this.typeChoose.Text = "Типы";
            this.typeChoose.UseVisualStyleBackColor = true;
            this.typeChoose.CheckedChanged += new System.EventHandler(this.typeChoose_CheckedChanged);
            // 
            // meetChoose
            // 
            this.meetChoose.AutoSize = true;
            this.meetChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.meetChoose.Location = new System.Drawing.Point(0, 0);
            this.meetChoose.Name = "meetChoose";
            this.meetChoose.Padding = new System.Windows.Forms.Padding(6);
            this.meetChoose.Size = new System.Drawing.Size(120, 29);
            this.meetChoose.TabIndex = 6;
            this.meetChoose.TabStop = true;
            this.meetChoose.Text = "Встречи";
            this.meetChoose.UseVisualStyleBackColor = true;
            this.meetChoose.CheckedChanged += new System.EventHandler(this.meetChoose_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.Controls.Add(this.panel6);
            this.flowLayoutPanel2.Controls.Add(this.panel12);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(350, 10);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(200, 180);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(200, 180);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 180);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(195, 25);
            this.panel5.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Название статуса";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.statusText);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(195, 25);
            this.panel6.TabIndex = 2;
            // 
            // statusText
            // 
            this.statusText.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusText.Location = new System.Drawing.Point(0, 0);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(195, 20);
            this.statusText.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.addStatus);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(3, 65);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.panel12.Size = new System.Drawing.Size(195, 50);
            this.panel12.TabIndex = 5;
            // 
            // addStatus
            // 
            this.addStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStatus.Location = new System.Drawing.Point(25, 10);
            this.addStatus.Name = "addStatus";
            this.addStatus.Size = new System.Drawing.Size(145, 30);
            this.addStatus.TabIndex = 0;
            this.addStatus.Text = "Добавить статус";
            this.addStatus.UseVisualStyleBackColor = true;
            this.addStatus.Click += new System.EventHandler(this.addStatus_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel11);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(200, 180);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(200, 180);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 180);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 25);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(112, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название типа";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.typeText);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 25);
            this.panel4.TabIndex = 1;
            // 
            // typeText
            // 
            this.typeText.Dock = System.Windows.Forms.DockStyle.Top;
            this.typeText.Location = new System.Drawing.Point(0, 0);
            this.typeText.Name = "typeText";
            this.typeText.Size = new System.Drawing.Size(195, 20);
            this.typeText.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.addType);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(3, 65);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.panel11.Size = new System.Drawing.Size(195, 50);
            this.panel11.TabIndex = 4;
            // 
            // addType
            // 
            this.addType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addType.Location = new System.Drawing.Point(25, 10);
            this.addType.Name = "addType";
            this.addType.Size = new System.Drawing.Size(145, 30);
            this.addType.TabIndex = 0;
            this.addType.Text = "Добавить тип";
            this.addType.UseVisualStyleBackColor = true;
            this.addType.Click += new System.EventHandler(this.addType_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resultView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(12, 210);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.MaximumSize = new System.Drawing.Size(560, 300);
            this.panel2.MinimumSize = new System.Drawing.Size(560, 300);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(560, 300);
            this.panel2.TabIndex = 1;
            // 
            // resultView
            // 
            this.resultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultView.Location = new System.Drawing.Point(10, 10);
            this.resultView.Name = "resultView";
            this.resultView.Size = new System.Drawing.Size(540, 280);
            this.resultView.TabIndex = 0;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.eraseLine);
            this.panel18.Controls.Add(this.deletedLineNumber);
            this.panel18.Controls.Add(this.backButton);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(12, 510);
            this.panel18.Name = "panel18";
            this.panel18.Padding = new System.Windows.Forms.Padding(5);
            this.panel18.Size = new System.Drawing.Size(562, 41);
            this.panel18.TabIndex = 2;
            // 
            // eraseLine
            // 
            this.eraseLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.eraseLine.Location = new System.Drawing.Point(126, 5);
            this.eraseLine.Name = "eraseLine";
            this.eraseLine.Size = new System.Drawing.Size(110, 31);
            this.eraseLine.TabIndex = 4;
            this.eraseLine.Text = "Удалить строку";
            this.eraseLine.UseVisualStyleBackColor = true;
            this.eraseLine.Click += new System.EventHandler(this.eraseLine_Click);
            // 
            // deletedLineNumber
            // 
            this.deletedLineNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.deletedLineNumber.FormattingEnabled = true;
            this.deletedLineNumber.Location = new System.Drawing.Point(5, 5);
            this.deletedLineNumber.Name = "deletedLineNumber";
            this.deletedLineNumber.Size = new System.Drawing.Size(121, 21);
            this.deletedLineNumber.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.backButton.Location = new System.Drawing.Point(447, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 31);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.Name = "AdminMain";
            this.Padding = new System.Windows.Forms.Padding(12, 10, 10, 10);
            this.Text = "AdminMain";
            this.panel1.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            this.panel18.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox typeText;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button addType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button addStatus;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button eraseLine;
        private System.Windows.Forms.ComboBox deletedLineNumber;
        private System.Windows.Forms.RadioButton roleChooose;
        private System.Windows.Forms.RadioButton meetChoose;
        private System.Windows.Forms.RadioButton typeChoose;
        private System.Windows.Forms.RadioButton statusChoose;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView resultView;
        private System.Windows.Forms.RadioButton accountChoose;
    }
}