namespace GUI
{
    partial class Registrering_Alumn
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
            this.firstNameTextb = new System.Windows.Forms.TextBox();
            this.emailTextb = new System.Windows.Forms.TextBox();
            this.pwTextb = new System.Windows.Forms.TextBox();
            this.phoneNrTextb = new System.Windows.Forms.TextBox();
            this.confirmPwTextb = new System.Windows.Forms.TextBox();
            this.surNameTextb = new System.Windows.Forms.TextBox();
            this.namnLabel = new System.Windows.Forms.Label();
            this.efterNamnLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.tlfnLabel = new System.Windows.Forms.Label();
            this.utbildningLabel = new System.Windows.Forms.Label();
            this.lösenOrdLabel = new System.Windows.Forms.Label();
            this.blösenordLabel = new System.Windows.Forms.Label();
            this.educationComboBox = new System.Windows.Forms.ComboBox();
            this.showPWCheckbox = new System.Windows.Forms.CheckBox();
            this.showPW2checkbox = new System.Windows.Forms.CheckBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.workCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // firstNameTextb
            // 
            this.firstNameTextb.Location = new System.Drawing.Point(229, 61);
            this.firstNameTextb.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextb.Name = "firstNameTextb";
            this.firstNameTextb.Size = new System.Drawing.Size(129, 23);
            this.firstNameTextb.TabIndex = 0;
            // 
            // emailTextb
            // 
            this.emailTextb.Location = new System.Drawing.Point(229, 105);
            this.emailTextb.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextb.Name = "emailTextb";
            this.emailTextb.Size = new System.Drawing.Size(129, 23);
            this.emailTextb.TabIndex = 2;
            // 
            // pwTextb
            // 
            this.pwTextb.Location = new System.Drawing.Point(229, 172);
            this.pwTextb.Margin = new System.Windows.Forms.Padding(2);
            this.pwTextb.Name = "pwTextb";
            this.pwTextb.Size = new System.Drawing.Size(129, 23);
            this.pwTextb.TabIndex = 5;
            this.pwTextb.TextChanged += new System.EventHandler(this.lösenordTB_TextChanged);
            // 
            // phoneNrTextb
            // 
            this.phoneNrTextb.Location = new System.Drawing.Point(229, 127);
            this.phoneNrTextb.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNrTextb.Name = "phoneNrTextb";
            this.phoneNrTextb.Size = new System.Drawing.Size(129, 23);
            this.phoneNrTextb.TabIndex = 3;
            // 
            // confirmPwTextb
            // 
            this.confirmPwTextb.Location = new System.Drawing.Point(229, 194);
            this.confirmPwTextb.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPwTextb.Name = "confirmPwTextb";
            this.confirmPwTextb.Size = new System.Drawing.Size(129, 23);
            this.confirmPwTextb.TabIndex = 6;
            this.confirmPwTextb.TextChanged += new System.EventHandler(this.blösenordTB_TextChanged);
            // 
            // surNameTextb
            // 
            this.surNameTextb.Location = new System.Drawing.Point(229, 83);
            this.surNameTextb.Margin = new System.Windows.Forms.Padding(2);
            this.surNameTextb.Name = "surNameTextb";
            this.surNameTextb.Size = new System.Drawing.Size(129, 23);
            this.surNameTextb.TabIndex = 1;
            // 
            // namnLabel
            // 
            this.namnLabel.AutoSize = true;
            this.namnLabel.Location = new System.Drawing.Point(107, 61);
            this.namnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namnLabel.Name = "namnLabel";
            this.namnLabel.Size = new System.Drawing.Size(48, 15);
            this.namnLabel.TabIndex = 1;
            this.namnLabel.Text = "Namn *";
            // 
            // efterNamnLabel
            // 
            this.efterNamnLabel.AutoSize = true;
            this.efterNamnLabel.Location = new System.Drawing.Point(107, 83);
            this.efterNamnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.efterNamnLabel.Name = "efterNamnLabel";
            this.efterNamnLabel.Size = new System.Drawing.Size(70, 15);
            this.efterNamnLabel.TabIndex = 1;
            this.efterNamnLabel.Text = "Efternamn *";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(107, 105);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 15);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email *";
            // 
            // tlfnLabel
            // 
            this.tlfnLabel.AutoSize = true;
            this.tlfnLabel.Location = new System.Drawing.Point(107, 127);
            this.tlfnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tlfnLabel.Name = "tlfnLabel";
            this.tlfnLabel.Size = new System.Drawing.Size(96, 15);
            this.tlfnLabel.TabIndex = 1;
            this.tlfnLabel.Text = "Telefonnummer*";
            // 
            // utbildningLabel
            // 
            this.utbildningLabel.AutoSize = true;
            this.utbildningLabel.Location = new System.Drawing.Point(107, 149);
            this.utbildningLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.utbildningLabel.Name = "utbildningLabel";
            this.utbildningLabel.Size = new System.Drawing.Size(71, 15);
            this.utbildningLabel.TabIndex = 1;
            this.utbildningLabel.Text = "Utbildning *";
            // 
            // lösenOrdLabel
            // 
            this.lösenOrdLabel.AutoSize = true;
            this.lösenOrdLabel.Location = new System.Drawing.Point(107, 172);
            this.lösenOrdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lösenOrdLabel.Name = "lösenOrdLabel";
            this.lösenOrdLabel.Size = new System.Drawing.Size(64, 15);
            this.lösenOrdLabel.TabIndex = 1;
            this.lösenOrdLabel.Text = "Lösenord *";
            // 
            // blösenordLabel
            // 
            this.blösenordLabel.AutoSize = true;
            this.blösenordLabel.Location = new System.Drawing.Point(107, 194);
            this.blösenordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blösenordLabel.Name = "blösenordLabel";
            this.blösenordLabel.Size = new System.Drawing.Size(111, 15);
            this.blösenordLabel.TabIndex = 1;
            this.blösenordLabel.Text = "berkräfta lösenord *";
            // 
            // educationComboBox
            // 
            this.educationComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.educationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.educationComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.educationComboBox.FormattingEnabled = true;
            this.educationComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.educationComboBox.Items.AddRange(new object[] {
            "Dataekonom",
            "Systemvetare",
            "Systemarkitekt"});
            this.educationComboBox.Location = new System.Drawing.Point(229, 149);
            this.educationComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.educationComboBox.Name = "educationComboBox";
            this.educationComboBox.Size = new System.Drawing.Size(129, 23);
            this.educationComboBox.TabIndex = 4;
            // 
            // showPWCheckbox
            // 
            this.showPWCheckbox.AutoSize = true;
            this.showPWCheckbox.Location = new System.Drawing.Point(370, 172);
            this.showPWCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.showPWCheckbox.Name = "showPWCheckbox";
            this.showPWCheckbox.Size = new System.Drawing.Size(95, 19);
            this.showPWCheckbox.TabIndex = 4;
            this.showPWCheckbox.TabStop = false;
            this.showPWCheckbox.Text = "visa lösenord";
            this.showPWCheckbox.UseVisualStyleBackColor = true;
            this.showPWCheckbox.CheckedChanged += new System.EventHandler(this.showPWCheckbox_CheckedChanged);
            // 
            // showPW2checkbox
            // 
            this.showPW2checkbox.AutoSize = true;
            this.showPW2checkbox.Location = new System.Drawing.Point(370, 195);
            this.showPW2checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.showPW2checkbox.Name = "showPW2checkbox";
            this.showPW2checkbox.Size = new System.Drawing.Size(95, 19);
            this.showPW2checkbox.TabIndex = 4;
            this.showPW2checkbox.TabStop = false;
            this.showPW2checkbox.Text = "visa lösenord";
            this.showPW2checkbox.UseVisualStyleBackColor = true;
            this.showPW2checkbox.CheckedChanged += new System.EventHandler(this.showPW2checkbox_CheckedChanged);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(280, 255);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(78, 20);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Registrera";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(107, 255);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(78, 20);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Rensa";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "* Obligatoriska fält";
            // 
            // workCheckbox
            // 
            this.workCheckbox.AutoSize = true;
            this.workCheckbox.Location = new System.Drawing.Point(293, 221);
            this.workCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.workCheckbox.Name = "workCheckbox";
            this.workCheckbox.Size = new System.Drawing.Size(65, 19);
            this.workCheckbox.TabIndex = 4;
            this.workCheckbox.TabStop = false;
            this.workCheckbox.Text = "Arbetar";
            this.workCheckbox.UseVisualStyleBackColor = true;
            // 
            // Registrering_Alumn
            // 
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 300);
            this.ControlBox = false;
            this.Controls.Add(this.workCheckbox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.tlfnLabel);
            this.Controls.Add(this.namnLabel);
            this.Controls.Add(this.blösenordLabel);
            this.Controls.Add(this.lösenOrdLabel);
            this.Controls.Add(this.utbildningLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.efterNamnLabel);
            this.Controls.Add(this.emailTextb);
            this.Controls.Add(this.surNameTextb);
            this.Controls.Add(this.firstNameTextb);
            this.Controls.Add(this.pwTextb);
            this.Controls.Add(this.confirmPwTextb);
            this.Controls.Add(this.showPWCheckbox);
            this.Controls.Add(this.showPW2checkbox);
            this.Controls.Add(this.educationComboBox);
            this.Controls.Add(this.phoneNrTextb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registrering_Alumn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrering_Alumn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextb;
        private System.Windows.Forms.TextBox emailTextb;
        private System.Windows.Forms.TextBox pwTextb;
        private System.Windows.Forms.TextBox phoneNrTextb;
        private System.Windows.Forms.TextBox confirmPwTextb;
        private System.Windows.Forms.TextBox surNameTextb;
        private System.Windows.Forms.Label namnLabel;
        private System.Windows.Forms.Label efterNamnLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label tlfnLabel;
        private System.Windows.Forms.Label utbildningLabel;
        private System.Windows.Forms.Label lösenOrdLabel;
        private System.Windows.Forms.Label blösenordLabel;
        private System.Windows.Forms.ComboBox educationComboBox;
        private System.Windows.Forms.CheckBox showPWCheckbox;
        private System.Windows.Forms.CheckBox showPW2checkbox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox workCheckbox;
    }
}