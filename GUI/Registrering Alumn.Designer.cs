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
            this.namnTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.lösenordTB = new System.Windows.Forms.TextBox();
            this.tlfnnrTB = new System.Windows.Forms.TextBox();
            this.blösenordTB = new System.Windows.Forms.TextBox();
            this.enamnTB = new System.Windows.Forms.TextBox();
            this.namnLabel = new System.Windows.Forms.Label();
            this.efterNamnLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.tlfnLabel = new System.Windows.Forms.Label();
            this.utbildningLabel = new System.Windows.Forms.Label();
            this.lösenOrdLabel = new System.Windows.Forms.Label();
            this.blösenordLabel = new System.Windows.Forms.Label();
            this.utbildningCBox = new System.Windows.Forms.ComboBox();
            this.showPWCheckbox = new System.Windows.Forms.CheckBox();
            this.showPW2checkbox = new System.Windows.Forms.CheckBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namnTB
            // 
            this.namnTB.Location = new System.Drawing.Point(327, 101);
            this.namnTB.Name = "namnTB";
            this.namnTB.Size = new System.Drawing.Size(182, 31);
            this.namnTB.TabIndex = 0;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(327, 175);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(182, 31);
            this.emailTB.TabIndex = 2;
            // 
            // lösenordTB
            // 
            this.lösenordTB.Location = new System.Drawing.Point(327, 286);
            this.lösenordTB.Name = "lösenordTB";
            this.lösenordTB.Size = new System.Drawing.Size(182, 31);
            this.lösenordTB.TabIndex = 5;
            this.lösenordTB.TextChanged += new System.EventHandler(this.lösenordTB_TextChanged);
            // 
            // tlfnnrTB
            // 
            this.tlfnnrTB.Location = new System.Drawing.Point(327, 212);
            this.tlfnnrTB.Name = "tlfnnrTB";
            this.tlfnnrTB.Size = new System.Drawing.Size(182, 31);
            this.tlfnnrTB.TabIndex = 3;
            // 
            // blösenordTB
            // 
            this.blösenordTB.Location = new System.Drawing.Point(327, 323);
            this.blösenordTB.Name = "blösenordTB";
            this.blösenordTB.Size = new System.Drawing.Size(182, 31);
            this.blösenordTB.TabIndex = 6;
            this.blösenordTB.TextChanged += new System.EventHandler(this.blösenordTB_TextChanged);
            // 
            // enamnTB
            // 
            this.enamnTB.Location = new System.Drawing.Point(327, 138);
            this.enamnTB.Name = "enamnTB";
            this.enamnTB.Size = new System.Drawing.Size(182, 31);
            this.enamnTB.TabIndex = 1;
            // 
            // namnLabel
            // 
            this.namnLabel.AutoSize = true;
            this.namnLabel.Location = new System.Drawing.Point(153, 101);
            this.namnLabel.Name = "namnLabel";
            this.namnLabel.Size = new System.Drawing.Size(73, 25);
            this.namnLabel.TabIndex = 1;
            this.namnLabel.Text = "Namn *";
            // 
            // efterNamnLabel
            // 
            this.efterNamnLabel.AutoSize = true;
            this.efterNamnLabel.Location = new System.Drawing.Point(153, 138);
            this.efterNamnLabel.Name = "efterNamnLabel";
            this.efterNamnLabel.Size = new System.Drawing.Size(106, 25);
            this.efterNamnLabel.TabIndex = 1;
            this.efterNamnLabel.Text = "Efternamn *";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(153, 175);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(67, 25);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email *";
            // 
            // tlfnLabel
            // 
            this.tlfnLabel.AutoSize = true;
            this.tlfnLabel.Location = new System.Drawing.Point(153, 212);
            this.tlfnLabel.Name = "tlfnLabel";
            this.tlfnLabel.Size = new System.Drawing.Size(135, 25);
            this.tlfnLabel.TabIndex = 1;
            this.tlfnLabel.Text = "Telefonnummer";
            // 
            // utbildningLabel
            // 
            this.utbildningLabel.AutoSize = true;
            this.utbildningLabel.Location = new System.Drawing.Point(153, 249);
            this.utbildningLabel.Name = "utbildningLabel";
            this.utbildningLabel.Size = new System.Drawing.Size(108, 25);
            this.utbildningLabel.TabIndex = 1;
            this.utbildningLabel.Text = "Utbildning *";
            // 
            // lösenOrdLabel
            // 
            this.lösenOrdLabel.AutoSize = true;
            this.lösenOrdLabel.Location = new System.Drawing.Point(153, 286);
            this.lösenOrdLabel.Name = "lösenOrdLabel";
            this.lösenOrdLabel.Size = new System.Drawing.Size(99, 25);
            this.lösenOrdLabel.TabIndex = 1;
            this.lösenOrdLabel.Text = "Lösenord *";
            // 
            // blösenordLabel
            // 
            this.blösenordLabel.AutoSize = true;
            this.blösenordLabel.Location = new System.Drawing.Point(153, 323);
            this.blösenordLabel.Name = "blösenordLabel";
            this.blösenordLabel.Size = new System.Drawing.Size(171, 25);
            this.blösenordLabel.TabIndex = 1;
            this.blösenordLabel.Text = "berkräfta lösenord *";
            // 
            // utbildningCBox
            // 
            this.utbildningCBox.BackColor = System.Drawing.SystemColors.Window;
            this.utbildningCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.utbildningCBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.utbildningCBox.FormattingEnabled = true;
            this.utbildningCBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.utbildningCBox.Items.AddRange(new object[] {
            "Dataekonom",
            "Systemvetare",
            "Systemarkitekt"});
            this.utbildningCBox.Location = new System.Drawing.Point(327, 249);
            this.utbildningCBox.Name = "utbildningCBox";
            this.utbildningCBox.Size = new System.Drawing.Size(182, 33);
            this.utbildningCBox.TabIndex = 4;
            // 
            // showPWCheckbox
            // 
            this.showPWCheckbox.AutoSize = true;
            this.showPWCheckbox.Location = new System.Drawing.Point(528, 286);
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
            this.showPW2checkbox.Location = new System.Drawing.Point(528, 325);
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
            this.registerButton.Location = new System.Drawing.Point(397, 389);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(112, 34);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Registrera";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(166, 389);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 34);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Rensa";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "* Obligatoriska fält";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registrering_Alumn
            // 
            this.AcceptButton = this.registerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 500);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tlfnLabel);
            this.Controls.Add(this.namnLabel);
            this.Controls.Add(this.blösenordLabel);
            this.Controls.Add(this.lösenOrdLabel);
            this.Controls.Add(this.utbildningLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.efterNamnLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.enamnTB);
            this.Controls.Add(this.namnTB);
            this.Controls.Add(this.lösenordTB);
            this.Controls.Add(this.blösenordTB);
            this.Controls.Add(this.showPWCheckbox);
            this.Controls.Add(this.showPW2checkbox);
            this.Controls.Add(this.utbildningCBox);
            this.Controls.Add(this.tlfnnrTB);
            this.Name = "Registrering_Alumn";
            this.Text = "Registrering_Alumn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namnTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox lösenordTB;
        private System.Windows.Forms.TextBox tlfnnrTB;
        private System.Windows.Forms.TextBox blösenordTB;
        private System.Windows.Forms.TextBox enamnTB;
        private System.Windows.Forms.Label namnLabel;
        private System.Windows.Forms.Label efterNamnLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label tlfnLabel;
        private System.Windows.Forms.Label utbildningLabel;
        private System.Windows.Forms.Label lösenOrdLabel;
        private System.Windows.Forms.Label blösenordLabel;
        private System.Windows.Forms.ComboBox utbildningCBox;
        private System.Windows.Forms.CheckBox showPWCheckbox;
        private System.Windows.Forms.CheckBox showPW2checkbox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}