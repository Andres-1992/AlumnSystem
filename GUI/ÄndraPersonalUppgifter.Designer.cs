namespace GUI
{
    partial class ÄndraPersonalUppgifter
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
            this.Cancelbutton1 = new System.Windows.Forms.Button();
            this.Applybutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNametextBox1 = new System.Windows.Forms.TextBox();
            this.SurnametextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailtextBox1 = new System.Windows.Forms.TextBox();
            this.PhoneNumbertextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancelbutton1
            // 
            this.Cancelbutton1.Location = new System.Drawing.Point(12, 147);
            this.Cancelbutton1.Name = "Cancelbutton1";
            this.Cancelbutton1.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton1.TabIndex = 0;
            this.Cancelbutton1.Text = "Avbryt";
            this.Cancelbutton1.UseVisualStyleBackColor = true;
            this.Cancelbutton1.Click += new System.EventHandler(this.Cancelbutton1_Click);
            // 
            // Applybutton1
            // 
            this.Applybutton1.Location = new System.Drawing.Point(126, 147);
            this.Applybutton1.Name = "Applybutton1";
            this.Applybutton1.Size = new System.Drawing.Size(75, 23);
            this.Applybutton1.TabIndex = 0;
            this.Applybutton1.Text = "Godkänn";
            this.Applybutton1.UseVisualStyleBackColor = true;
            this.Applybutton1.Click += new System.EventHandler(this.Applybutton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Förnamn";
            // 
            // FirstNametextBox1
            // 
            this.FirstNametextBox1.Location = new System.Drawing.Point(101, 20);
            this.FirstNametextBox1.Name = "FirstNametextBox1";
            this.FirstNametextBox1.Size = new System.Drawing.Size(100, 23);
            this.FirstNametextBox1.TabIndex = 2;
            this.FirstNametextBox1.TextChanged += new System.EventHandler(this.FirstNametextBox1_TextChanged);
            // 
            // SurnametextBox1
            // 
            this.SurnametextBox1.Location = new System.Drawing.Point(101, 49);
            this.SurnametextBox1.Name = "SurnametextBox1";
            this.SurnametextBox1.Size = new System.Drawing.Size(100, 23);
            this.SurnametextBox1.TabIndex = 2;
            this.SurnametextBox1.TextChanged += new System.EventHandler(this.SurnametextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Efternamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // EmailtextBox1
            // 
            this.EmailtextBox1.Location = new System.Drawing.Point(101, 107);
            this.EmailtextBox1.Name = "EmailtextBox1";
            this.EmailtextBox1.Size = new System.Drawing.Size(100, 23);
            this.EmailtextBox1.TabIndex = 2;
            this.EmailtextBox1.TextChanged += new System.EventHandler(this.EmailtextBox1_TextChanged);
            // 
            // PhoneNumbertextBox1
            // 
            this.PhoneNumbertextBox1.Location = new System.Drawing.Point(101, 78);
            this.PhoneNumbertextBox1.Name = "PhoneNumbertextBox1";
            this.PhoneNumbertextBox1.Size = new System.Drawing.Size(100, 23);
            this.PhoneNumbertextBox1.TabIndex = 2;
            this.PhoneNumbertextBox1.TextChanged += new System.EventHandler(this.PhoneNumbertextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefonnummer";
            // 
            // ÄndraPersonalUppgifter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 179);
            this.Controls.Add(this.Cancelbutton1);
            this.Controls.Add(this.Applybutton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNametextBox1);
            this.Controls.Add(this.SurnametextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneNumbertextBox1);
            this.Controls.Add(this.EmailtextBox1);
            this.Controls.Add(this.label3);
            this.Name = "ÄndraPersonalUppgifter";
            this.Text = "Ändra uppgifter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelbutton1;
        private System.Windows.Forms.Button Applybutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNametextBox1;
        private System.Windows.Forms.TextBox SurnametextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailtextBox1;
        private System.Windows.Forms.TextBox PhoneNumbertextBox1;
        private System.Windows.Forms.Label label4;
    }
}