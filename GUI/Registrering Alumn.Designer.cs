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
            this.GDPRlink = new System.Windows.Forms.LinkLabel();
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
            this.firstNameTextb.Location = new System.Drawing.Point(219, 30);
            this.firstNameTextb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNameTextb.Name = "firstNameTextb";
            this.firstNameTextb.Size = new System.Drawing.Size(129, 23);
            this.firstNameTextb.TabIndex = 0;
            // 
            // emailTextb
            // 
            this.emailTextb.Location = new System.Drawing.Point(219, 74);
            this.emailTextb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextb.Name = "emailTextb";
            this.emailTextb.Size = new System.Drawing.Size(129, 23);
            this.emailTextb.TabIndex = 2;
            // 
            // pwTextb
            // 
            this.pwTextb.Location = new System.Drawing.Point(219, 141);
            this.pwTextb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pwTextb.Name = "pwTextb";
            this.pwTextb.Size = new System.Drawing.Size(129, 23);
            this.pwTextb.TabIndex = 5;
            this.pwTextb.TextChanged += new System.EventHandler(this.lösenordTB_TextChanged);
            // 
            // phoneNrTextb
            // 
            this.phoneNrTextb.Location = new System.Drawing.Point(219, 96);
            this.phoneNrTextb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneNrTextb.Name = "phoneNrTextb";
            this.phoneNrTextb.Size = new System.Drawing.Size(129, 23);
            this.phoneNrTextb.TabIndex = 3;
            // 
            // confirmPwTextb
            // 
            this.confirmPwTextb.Location = new System.Drawing.Point(219, 163);
            this.confirmPwTextb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmPwTextb.Name = "confirmPwTextb";
            this.confirmPwTextb.Size = new System.Drawing.Size(129, 23);
            this.confirmPwTextb.TabIndex = 6;
            this.confirmPwTextb.TextChanged += new System.EventHandler(this.blösenordTB_TextChanged);
            // 
            // surNameTextb
            // 
            this.surNameTextb.Location = new System.Drawing.Point(219, 52);
            this.surNameTextb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.surNameTextb.Name = "surNameTextb";
            this.surNameTextb.Size = new System.Drawing.Size(129, 23);
            this.surNameTextb.TabIndex = 1;
            // 
            // namnLabel
            // 
            this.namnLabel.AutoSize = true;
            this.namnLabel.Location = new System.Drawing.Point(97, 30);
            this.namnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namnLabel.Name = "namnLabel";
            this.namnLabel.Size = new System.Drawing.Size(48, 15);
            this.namnLabel.TabIndex = 1;
            this.namnLabel.Text = "Namn *";
            // 
            // efterNamnLabel
            // 
            this.efterNamnLabel.AutoSize = true;
            this.efterNamnLabel.Location = new System.Drawing.Point(97, 52);
            this.efterNamnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.efterNamnLabel.Name = "efterNamnLabel";
            this.efterNamnLabel.Size = new System.Drawing.Size(70, 15);
            this.efterNamnLabel.TabIndex = 1;
            this.efterNamnLabel.Text = "Efternamn *";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(97, 74);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 15);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email *";
            // 
            // tlfnLabel
            // 
            this.tlfnLabel.AutoSize = true;
            this.tlfnLabel.Location = new System.Drawing.Point(97, 96);
            this.tlfnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tlfnLabel.Name = "tlfnLabel";
            this.tlfnLabel.Size = new System.Drawing.Size(96, 15);
            this.tlfnLabel.TabIndex = 1;
            this.tlfnLabel.Text = "Telefonnummer*";
            // 
            // utbildningLabel
            // 
            this.utbildningLabel.AutoSize = true;
            this.utbildningLabel.Location = new System.Drawing.Point(97, 118);
            this.utbildningLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.utbildningLabel.Name = "utbildningLabel";
            this.utbildningLabel.Size = new System.Drawing.Size(71, 15);
            this.utbildningLabel.TabIndex = 1;
            this.utbildningLabel.Text = "Utbildning *";
            // 
            // lösenOrdLabel
            // 
            this.lösenOrdLabel.AutoSize = true;
            this.lösenOrdLabel.Location = new System.Drawing.Point(97, 141);
            this.lösenOrdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lösenOrdLabel.Name = "lösenOrdLabel";
            this.lösenOrdLabel.Size = new System.Drawing.Size(64, 15);
            this.lösenOrdLabel.TabIndex = 1;
            this.lösenOrdLabel.Text = "Lösenord *";
            // 
            // blösenordLabel
            // 
            this.blösenordLabel.AutoSize = true;
            this.blösenordLabel.Location = new System.Drawing.Point(97, 163);
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
            this.educationComboBox.Location = new System.Drawing.Point(219, 118);
            this.educationComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.educationComboBox.Name = "educationComboBox";
            this.educationComboBox.Size = new System.Drawing.Size(129, 23);
            this.educationComboBox.TabIndex = 4;
            // 
            // showPWCheckbox
            // 
            this.showPWCheckbox.AutoSize = true;
            this.showPWCheckbox.Location = new System.Drawing.Point(360, 141);
            this.showPWCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.showPW2checkbox.Location = new System.Drawing.Point(360, 164);
            this.showPW2checkbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.registerButton.Enabled = false;
            this.registerButton.Location = new System.Drawing.Point(270, 458);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(78, 20);
            this.registerButton.TabIndex = 13;
            this.registerButton.Text = "Registrera";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(139, 458);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(78, 20);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Rensa";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // workCheckbox
            // 
            this.workCheckbox.AutoSize = true;
            this.workCheckbox.Location = new System.Drawing.Point(284, 190);
            this.workCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.workCheckbox.Name = "workCheckbox";
            this.workCheckbox.Size = new System.Drawing.Size(65, 19);
            this.workCheckbox.TabIndex = 7;
            this.workCheckbox.TabStop = false;
            this.workCheckbox.Text = "Arbetar";
            this.workCheckbox.UseVisualStyleBackColor = true;
            // 
            // GDPRcheckbox
            // 
            this.GDPRcheckbox.AutoSize = true;
            this.GDPRcheckbox.Location = new System.Drawing.Point(233, 416);
            this.GDPRcheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GDPRcheckbox.Name = "GDPRcheckbox";
            this.GDPRcheckbox.Size = new System.Drawing.Size(109, 19);
            this.GDPRcheckbox.TabIndex = 11;
            this.GDPRcheckbox.Text = "GDPR samtycke";
            this.GDPRcheckbox.UseVisualStyleBackColor = true;
            this.GDPRcheckbox.CheckedChanged += new System.EventHandler(this.GDPRcheckbox_CheckedChanged);
            // 
            // GDPRlink
            // 
            this.GDPRlink.AutoSize = true;
            this.GDPRlink.Location = new System.Drawing.Point(238, 435);
            this.GDPRlink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GDPRlink.Name = "GDPRlink";
            this.GDPRlink.Size = new System.Drawing.Size(102, 15);
            this.GDPRlink.TabIndex = 12;
            this.GDPRlink.TabStop = true;
            this.GDPRlink.Text = "Läs mer om GDPR";
            this.GDPRlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GDPRlink_LinkClicked);
            // 
            // Competencelabel
            // 
            this.Competencelabel.AutoSize = true;
            this.Competencelabel.Location = new System.Drawing.Point(177, 209);
            this.Competencelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Competencelabel.Name = "Competencelabel";
            this.Competencelabel.Size = new System.Drawing.Size(158, 15);
            this.Competencelabel.TabIndex = 11;
            this.Competencelabel.Text = "Vad har du för kompetenser?";
            // 
            // competenceRichTextBox
            // 
            this.competenceRichTextBox.Location = new System.Drawing.Point(97, 235);
            this.competenceRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.competenceRichTextBox.Name = "competenceRichTextBox";
            this.competenceRichTextBox.Size = new System.Drawing.Size(251, 116);
            this.competenceRichTextBox.TabIndex = 8;
            this.competenceRichTextBox.Text = "";
            // 
            // competenceComboBox
            // 
            this.competenceComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.competenceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.competenceComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.competenceComboBox.FormattingEnabled = true;
            this.competenceComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.competenceComboBox.Location = new System.Drawing.Point(219, 353);
            this.competenceComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.competenceComboBox.Name = "competenceComboBox";
            this.competenceComboBox.Size = new System.Drawing.Size(129, 23);
            this.competenceComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kompetens nivå ";
            // 
            // AddCompetence
            // 
            this.AddCompetence.Location = new System.Drawing.Point(219, 377);
            this.AddCompetence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddCompetence.Name = "AddCompetence";
            this.AddCompetence.Size = new System.Drawing.Size(128, 20);
            this.AddCompetence.TabIndex = 10;
            this.AddCompetence.Text = "Lägg till kompetens";
            this.AddCompetence.UseVisualStyleBackColor = true;
            this.AddCompetence.Click += new System.EventHandler(this.AddCompetence_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cancelButton.Location = new System.Drawing.Point(28, 458);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(78, 20);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Avbryt";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Registrering_Alumn
            // 
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(502, 540);
            this.ControlBox = false;
            this.Controls.Add(this.AddCompetence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GDPRlink);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.LinkLabel GDPRlink;
        private System.Windows.Forms.Label Competencelabel;
        private System.Windows.Forms.RichTextBox competenceRichTextBox;
        private System.Windows.Forms.ComboBox competenceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCompetence;
        private System.Windows.Forms.Button cancelButton;
    }
}