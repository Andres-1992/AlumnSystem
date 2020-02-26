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
            this.workCheckbox = new System.Windows.Forms.CheckBox();
            this.GDPRcheckbox = new System.Windows.Forms.CheckBox();
            this.Competencelabel = new System.Windows.Forms.Label();
            this.competenceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.competenceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCompetence = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameTextb
            // 
            this.firstNameTextb.Location = new System.Drawing.Point(313, 50);
            this.firstNameTextb.Name = "firstNameTextb";
            this.firstNameTextb.Size = new System.Drawing.Size(183, 31);
            this.firstNameTextb.TabIndex = 0;
            // 
            // emailTextb
            // 
            this.emailTextb.Location = new System.Drawing.Point(313, 123);
            this.emailTextb.Name = "emailTextb";
            this.emailTextb.Size = new System.Drawing.Size(183, 31);
            this.emailTextb.TabIndex = 2;
            // 
            // pwTextb
            // 
            this.pwTextb.Location = new System.Drawing.Point(313, 235);
            this.pwTextb.Name = "pwTextb";
            this.pwTextb.Size = new System.Drawing.Size(183, 31);
            this.pwTextb.TabIndex = 5;
            this.pwTextb.TextChanged += new System.EventHandler(this.lösenordTB_TextChanged);
            // 
            // phoneNrTextb
            // 
            this.phoneNrTextb.Location = new System.Drawing.Point(313, 160);
            this.phoneNrTextb.Name = "phoneNrTextb";
            this.phoneNrTextb.Size = new System.Drawing.Size(183, 31);
            this.phoneNrTextb.TabIndex = 3;
            // 
            // confirmPwTextb
            // 
            this.confirmPwTextb.Location = new System.Drawing.Point(313, 272);
            this.confirmPwTextb.Name = "confirmPwTextb";
            this.confirmPwTextb.Size = new System.Drawing.Size(183, 31);
            this.confirmPwTextb.TabIndex = 6;
            this.confirmPwTextb.TextChanged += new System.EventHandler(this.blösenordTB_TextChanged);
            // 
            // surNameTextb
            // 
            this.surNameTextb.Location = new System.Drawing.Point(313, 87);
            this.surNameTextb.Name = "surNameTextb";
            this.surNameTextb.Size = new System.Drawing.Size(183, 31);
            this.surNameTextb.TabIndex = 1;
            // 
            // namnLabel
            // 
            this.namnLabel.AutoSize = true;
            this.namnLabel.Location = new System.Drawing.Point(139, 50);
            this.namnLabel.Name = "namnLabel";
            this.namnLabel.Size = new System.Drawing.Size(73, 25);
            this.namnLabel.TabIndex = 1;
            this.namnLabel.Text = "Namn *";
            // 
            // efterNamnLabel
            // 
            this.efterNamnLabel.AutoSize = true;
            this.efterNamnLabel.Location = new System.Drawing.Point(139, 87);
            this.efterNamnLabel.Name = "efterNamnLabel";
            this.efterNamnLabel.Size = new System.Drawing.Size(106, 25);
            this.efterNamnLabel.TabIndex = 1;
            this.efterNamnLabel.Text = "Efternamn *";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(139, 123);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(67, 25);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email *";
            // 
            // tlfnLabel
            // 
            this.tlfnLabel.AutoSize = true;
            this.tlfnLabel.Location = new System.Drawing.Point(139, 160);
            this.tlfnLabel.Name = "tlfnLabel";
            this.tlfnLabel.Size = new System.Drawing.Size(143, 25);
            this.tlfnLabel.TabIndex = 1;
            this.tlfnLabel.Text = "Telefonnummer*";
            // 
            // utbildningLabel
            // 
            this.utbildningLabel.AutoSize = true;
            this.utbildningLabel.Location = new System.Drawing.Point(139, 197);
            this.utbildningLabel.Name = "utbildningLabel";
            this.utbildningLabel.Size = new System.Drawing.Size(108, 25);
            this.utbildningLabel.TabIndex = 1;
            this.utbildningLabel.Text = "Utbildning *";
            // 
            // lösenOrdLabel
            // 
            this.lösenOrdLabel.AutoSize = true;
            this.lösenOrdLabel.Location = new System.Drawing.Point(139, 235);
            this.lösenOrdLabel.Name = "lösenOrdLabel";
            this.lösenOrdLabel.Size = new System.Drawing.Size(99, 25);
            this.lösenOrdLabel.TabIndex = 1;
            this.lösenOrdLabel.Text = "Lösenord *";
            // 
            // blösenordLabel
            // 
            this.blösenordLabel.AutoSize = true;
            this.blösenordLabel.Location = new System.Drawing.Point(139, 272);
            this.blösenordLabel.Name = "blösenordLabel";
            this.blösenordLabel.Size = new System.Drawing.Size(164, 25);
            this.blösenordLabel.TabIndex = 1;
            this.blösenordLabel.Text = "Bekräfta lösenord *";
            // 
            // educationComboBox
            // 
            this.educationComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.educationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.educationComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.educationComboBox.FormattingEnabled = true;
            this.educationComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.educationComboBox.Location = new System.Drawing.Point(313, 197);
            this.educationComboBox.Name = "educationComboBox";
            this.educationComboBox.Size = new System.Drawing.Size(183, 33);
            this.educationComboBox.TabIndex = 4;
            // 
            // showPWCheckbox
            // 
            this.showPWCheckbox.AutoSize = true;
            this.showPWCheckbox.Location = new System.Drawing.Point(514, 235);
            this.showPWCheckbox.Name = "showPWCheckbox";
            this.showPWCheckbox.Size = new System.Drawing.Size(143, 29);
            this.showPWCheckbox.TabIndex = 4;
            this.showPWCheckbox.TabStop = false;
            this.showPWCheckbox.Text = "visa lösenord";
            this.showPWCheckbox.UseVisualStyleBackColor = true;
            this.showPWCheckbox.CheckedChanged += new System.EventHandler(this.showPWCheckbox_CheckedChanged);
            // 
            // showPW2checkbox
            // 
            this.showPW2checkbox.AutoSize = true;
            this.showPW2checkbox.Location = new System.Drawing.Point(514, 273);
            this.showPW2checkbox.Name = "showPW2checkbox";
            this.showPW2checkbox.Size = new System.Drawing.Size(143, 29);
            this.showPW2checkbox.TabIndex = 4;
            this.showPW2checkbox.TabStop = false;
            this.showPW2checkbox.Text = "visa lösenord";
            this.showPW2checkbox.UseVisualStyleBackColor = true;
            this.showPW2checkbox.CheckedChanged += new System.EventHandler(this.showPW2checkbox_CheckedChanged);
            // 
            // registerButton
            // 
            this.registerButton.Enabled = false;
            this.registerButton.Location = new System.Drawing.Point(386, 763);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(111, 33);
            this.registerButton.TabIndex = 13;
            this.registerButton.Text = "Registrera";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(199, 763);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(111, 33);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Rensa";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // workCheckbox
            // 
            this.workCheckbox.AutoSize = true;
            this.workCheckbox.Location = new System.Drawing.Point(406, 317);
            this.workCheckbox.Name = "workCheckbox";
            this.workCheckbox.Size = new System.Drawing.Size(97, 29);
            this.workCheckbox.TabIndex = 7;
            this.workCheckbox.TabStop = false;
            this.workCheckbox.Text = "Arbetar";
            this.workCheckbox.UseVisualStyleBackColor = true;
            // 
            // GDPRcheckbox
            // 
            this.GDPRcheckbox.AutoSize = true;
            this.GDPRcheckbox.Location = new System.Drawing.Point(333, 693);
            this.GDPRcheckbox.Name = "GDPRcheckbox";
            this.GDPRcheckbox.Size = new System.Drawing.Size(163, 29);
            this.GDPRcheckbox.TabIndex = 11;
            this.GDPRcheckbox.Text = "GDPR samtycke";
            this.GDPRcheckbox.UseVisualStyleBackColor = true;
            this.GDPRcheckbox.CheckedChanged += new System.EventHandler(this.GDPRcheckbox_CheckedChanged);
            // 
            // Competencelabel
            // 
            this.Competencelabel.AutoSize = true;
            this.Competencelabel.Location = new System.Drawing.Point(253, 348);
            this.Competencelabel.Name = "Competencelabel";
            this.Competencelabel.Size = new System.Drawing.Size(243, 25);
            this.Competencelabel.TabIndex = 11;
            this.Competencelabel.Text = "Vad har du för kompetenser?";
            // 
            // competenceRichTextBox
            // 
            this.competenceRichTextBox.Location = new System.Drawing.Point(139, 392);
            this.competenceRichTextBox.Name = "competenceRichTextBox";
            this.competenceRichTextBox.Size = new System.Drawing.Size(357, 191);
            this.competenceRichTextBox.TabIndex = 8;
            this.competenceRichTextBox.Text = "";
            this.competenceRichTextBox.TextChanged += new System.EventHandler(this.competenceRichTextBox_TextChanged);
            // 
            // competenceComboBox
            // 
            this.competenceComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.competenceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.competenceComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.competenceComboBox.FormattingEnabled = true;
            this.competenceComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.competenceComboBox.Location = new System.Drawing.Point(313, 588);
            this.competenceComboBox.Name = "competenceComboBox";
            this.competenceComboBox.Size = new System.Drawing.Size(183, 33);
            this.competenceComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kompetens nivå ";
            // 
            // AddCompetence
            // 
            this.AddCompetence.Enabled = false;
            this.AddCompetence.Location = new System.Drawing.Point(313, 628);
            this.AddCompetence.Name = "AddCompetence";
            this.AddCompetence.Size = new System.Drawing.Size(183, 33);
            this.AddCompetence.TabIndex = 10;
            this.AddCompetence.Text = "Lägg till kompetens";
            this.AddCompetence.UseVisualStyleBackColor = true;
            this.AddCompetence.Click += new System.EventHandler(this.AddCompetence_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cancelButton.Location = new System.Drawing.Point(40, 763);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 33);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Avbryt";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Registrering_Alumn
            // 
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(717, 900);
            this.ControlBox = false;
            this.Controls.Add(this.AddCompetence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.GDPRcheckbox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.competenceComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.phoneNrTextb);
            this.Controls.Add(this.educationComboBox);
            this.Controls.Add(this.showPW2checkbox);
            this.Controls.Add(this.showPWCheckbox);
            this.Controls.Add(this.confirmPwTextb);
            this.Controls.Add(this.pwTextb);
            this.Controls.Add(this.surNameTextb);
            this.Controls.Add(this.emailTextb);
            this.Controls.Add(this.efterNamnLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.utbildningLabel);
            this.Controls.Add(this.lösenOrdLabel);
            this.Controls.Add(this.blösenordLabel);
            this.Controls.Add(this.namnLabel);
            this.Controls.Add(this.tlfnLabel);
            this.Controls.Add(this.workCheckbox);
            this.Controls.Add(this.competenceRichTextBox);
            this.Controls.Add(this.Competencelabel);
            this.Controls.Add(this.firstNameTextb);
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
        private System.Windows.Forms.CheckBox workCheckbox;
        private System.Windows.Forms.CheckBox GDPRcheckbox;
        private System.Windows.Forms.Label Competencelabel;
        private System.Windows.Forms.RichTextBox competenceRichTextBox;
        private System.Windows.Forms.ComboBox competenceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCompetence;
        private System.Windows.Forms.Button cancelButton;
    }
}