namespace GUI
{
    partial class LoggedInAlumn
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
            this.label1 = new System.Windows.Forms.Label();
            this.Attendbutton1 = new System.Windows.Forms.Button();
            this.AccountInfobutton2 = new System.Windows.Forms.Button();
            this.LogOutbutton2 = new System.Windows.Forms.Button();
            this.DeleteLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Välkommen";
            // 
            // Attendbutton1
            // 
            this.Attendbutton1.Location = new System.Drawing.Point(140, 205);
            this.Attendbutton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Attendbutton1.Name = "Attendbutton1";
            this.Attendbutton1.Size = new System.Drawing.Size(154, 38);
            this.Attendbutton1.TabIndex = 1;
            this.Attendbutton1.Text = "Delta i event";
            this.Attendbutton1.UseVisualStyleBackColor = true;
            this.Attendbutton1.Click += new System.EventHandler(this.Attendbutton1_Click);
            // 
            // AccountInfobutton2
            // 
            this.AccountInfobutton2.Location = new System.Drawing.Point(140, 287);
            this.AccountInfobutton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccountInfobutton2.Name = "AccountInfobutton2";
            this.AccountInfobutton2.Size = new System.Drawing.Size(154, 38);
            this.AccountInfobutton2.TabIndex = 2;
            this.AccountInfobutton2.Text = "Ändra uppgifter";
            this.AccountInfobutton2.UseVisualStyleBackColor = true;
            this.AccountInfobutton2.Click += new System.EventHandler(this.AccountInfobutton2_Click);
            // 
            // LogOutbutton2
            // 
            this.LogOutbutton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.LogOutbutton2.Location = new System.Drawing.Point(140, 475);
            this.LogOutbutton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogOutbutton2.Name = "LogOutbutton2";
            this.LogOutbutton2.Size = new System.Drawing.Size(154, 38);
            this.LogOutbutton2.TabIndex = 3;
            this.LogOutbutton2.Text = "Logga ut";
            this.LogOutbutton2.UseVisualStyleBackColor = true;
            this.LogOutbutton2.Click += new System.EventHandler(this.LogOutbutton2_Click);
            // 
            // DeleteLink
            // 
            this.DeleteLink.AutoSize = true;
            this.DeleteLink.LinkColor = System.Drawing.Color.Red;
            this.DeleteLink.Location = new System.Drawing.Point(165, 718);
            this.DeleteLink.Name = "DeleteLink";
            this.DeleteLink.Size = new System.Drawing.Size(119, 25);
            this.DeleteLink.TabIndex = 4;
            this.DeleteLink.TabStop = true;
            this.DeleteLink.Text = "Ta bort konto";
            this.DeleteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteLink_LinkClicked);
            // 
            // LoggedInAlumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 752);
            this.Controls.Add(this.DeleteLink);
            this.Controls.Add(this.LogOutbutton2);
            this.Controls.Add(this.AccountInfobutton2);
            this.Controls.Add(this.Attendbutton1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoggedInAlumn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InloggadAlumn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Attendbutton1;
        private System.Windows.Forms.Button AccountInfobutton2;
        private System.Windows.Forms.Button LogOutbutton2;
        private System.Windows.Forms.LinkLabel DeleteLink;
    }
}