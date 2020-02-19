namespace GUI
{
    partial class UpdateEmployee
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
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Applybutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNametextBox = new System.Windows.Forms.TextBox();
            this.SurnametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumbertextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Cancelbutton.Location = new System.Drawing.Point(64, 285);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(107, 38);
            this.Cancelbutton.TabIndex = 0;
            this.Cancelbutton.Text = "Avbryt";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Applybutton
            // 
            this.Applybutton.Location = new System.Drawing.Point(311, 285);
            this.Applybutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Applybutton.Name = "Applybutton";
            this.Applybutton.Size = new System.Drawing.Size(107, 38);
            this.Applybutton.TabIndex = 0;
            this.Applybutton.Text = "Godkänn";
            this.Applybutton.UseVisualStyleBackColor = true;
            this.Applybutton.Click += new System.EventHandler(this.Applybutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Förnamn";
            // 
            // FirstNametextBox
            // 
            this.FirstNametextBox.Location = new System.Drawing.Point(198, 73);
            this.FirstNametextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstNametextBox.Name = "FirstNametextBox";
            this.FirstNametextBox.Size = new System.Drawing.Size(220, 31);
            this.FirstNametextBox.TabIndex = 2;
            // 
            // SurnametextBox
            // 
            this.SurnametextBox.Location = new System.Drawing.Point(198, 122);
            this.SurnametextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SurnametextBox.Name = "SurnametextBox";
            this.SurnametextBox.Size = new System.Drawing.Size(220, 31);
            this.SurnametextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(198, 218);
            this.EmailtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(220, 31);
            this.EmailtextBox.TabIndex = 2;
            // 
            // PhoneNumbertextBox
            // 
            this.PhoneNumbertextBox.Location = new System.Drawing.Point(198, 170);
            this.PhoneNumbertextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneNumbertextBox.Name = "PhoneNumbertextBox";
            this.PhoneNumbertextBox.Size = new System.Drawing.Size(220, 31);
            this.PhoneNumbertextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefonnummer";
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 373);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Applybutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.PhoneNumbertextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurnametextBox);
            this.Controls.Add(this.FirstNametextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ändra uppgifter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Applybutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNametextBox;
        private System.Windows.Forms.TextBox SurnametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox PhoneNumbertextBox;
        private System.Windows.Forms.Label label4;
    }
}