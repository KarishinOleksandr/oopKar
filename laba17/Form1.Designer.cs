namespace laba17
{
    partial class Form1
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
            this.sendButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.chatTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(598, 347);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(206, 88);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Відправити";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(12, 347);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(564, 94);
            this.messageTextBox.TabIndex = 6;
            // 
            // chatTextBox
            // 
            this.chatTextBox.Location = new System.Drawing.Point(12, 115);
            this.chatTextBox.Multiline = true;
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.Size = new System.Drawing.Size(776, 226);
            this.chatTextBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFont);
            this.groupBox1.Controls.Add(this.logoutButton);
            this.groupBox1.Controls.Add(this.settingsButton);
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Controls.Add(this.lblHost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(645, 61);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 7;
            this.btnFont.Text = "Текст";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(466, 61);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Виход";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(645, 23);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 23);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Порт";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(466, 24);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Вход";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(208, 66);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "label3";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(90, 26);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(288, 20);
            this.userNameTextBox.TabIndex = 2;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(6, 66);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(31, 13);
            this.lblHost.TabIndex = 1;
            this.lblHost.Text = "Хост";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть ім\'я";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "laba17";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox chatTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

