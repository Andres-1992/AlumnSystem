namespace GUI
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.alumnRadioButton = new System.Windows.Forms.RadioButton();
            this.personalRadioButton = new System.Windows.Forms.RadioButton();
            this.idLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(223, 89);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(107, 23);
            this.userNameTextBox.TabIndex = 3;
            this.userNameTextBox.Text = "Email";
            this.userNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userNameTextBox_MouseClick);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(223, 111);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(107, 23);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.Text = "Lösenord";
            this.passwordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordTextBox_MouseClick);
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(223, 133);
            this.logInButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(106, 20);
            this.logInButton.TabIndex = 5;
            this.logInButton.Text = "Logga In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.AutoSize = true;
            this.registerLinkLabel.Location = new System.Drawing.Point(223, 165);
            this.registerLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Size = new System.Drawing.Size(99, 15);
            this.registerLinkLabel.TabIndex = 6;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "Registrera dig här";
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLabel_LinkClicked);
            // 
            // alumnRadioButton
            // 
            this.alumnRadioButton.AutoSize = true;
            this.alumnRadioButton.Checked = true;
            this.alumnRadioButton.Location = new System.Drawing.Point(242, 32);
            this.alumnRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alumnRadioButton.Name = "alumnRadioButton";
            this.alumnRadioButton.Size = new System.Drawing.Size(61, 19);
            this.alumnRadioButton.TabIndex = 1;
            this.alumnRadioButton.TabStop = true;
            this.alumnRadioButton.Text = "Alumn";
            this.alumnRadioButton.UseVisualStyleBackColor = true;
            // 
            // personalRadioButton
            // 
            this.personalRadioButton.AutoSize = true;
            this.personalRadioButton.Location = new System.Drawing.Point(242, 56);
            this.personalRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.personalRadioButton.Name = "personalRadioButton";
            this.personalRadioButton.Size = new System.Drawing.Size(70, 19);
            this.personalRadioButton.TabIndex = 2;
            this.personalRadioButton.Text = "Personal";
            this.personalRadioButton.UseVisualStyleBackColor = true;
            this.personalRadioButton.CheckedChanged += new System.EventHandler(this.personalRadioButton_CheckedChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(146, 89);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(36, 15);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(146, 115);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 15);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Lösenord";
            // 
            // Form1
            // 
            this.AcceptButton = this.logInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.personalRadioButton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.alumnRadioButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.registerLinkLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.passwordLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
        private System.Windows.Forms.RadioButton alumnRadioButton;
        private System.Windows.Forms.RadioButton personalRadioButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}

