namespace GUI
{
    partial class LoggedInEmployee
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
            this.CreateEventbutton1 = new System.Windows.Forms.Button();
            this.AccountInfobutton1 = new System.Windows.Forms.Button();
            this.LogOutbutton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Välkommen";
            // 
            // CreateEventbutton1
            // 
            this.CreateEventbutton1.Location = new System.Drawing.Point(94, 141);
            this.CreateEventbutton1.Name = "CreateEventbutton1";
            this.CreateEventbutton1.Size = new System.Drawing.Size(114, 23);
            this.CreateEventbutton1.TabIndex = 1;
            this.CreateEventbutton1.Text = "Skapa Event";
            this.CreateEventbutton1.UseVisualStyleBackColor = true;
            this.CreateEventbutton1.Click += new System.EventHandler(this.CreateEventbutton1_Click);
            // 
            // AccountInfobutton1
            // 
            this.AccountInfobutton1.Location = new System.Drawing.Point(94, 187);
            this.AccountInfobutton1.Name = "AccountInfobutton1";
            this.AccountInfobutton1.Size = new System.Drawing.Size(114, 23);
            this.AccountInfobutton1.TabIndex = 2;
            this.AccountInfobutton1.Text = "Ändra uppgifter";
            this.AccountInfobutton1.UseVisualStyleBackColor = true;
            this.AccountInfobutton1.Click += new System.EventHandler(this.AccountInfobutton1_Click);
            // 
            // LogOutbutton1
            // 
            this.LogOutbutton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.LogOutbutton1.Location = new System.Drawing.Point(94, 298);
            this.LogOutbutton1.Name = "LogOutbutton1";
            this.LogOutbutton1.Size = new System.Drawing.Size(114, 23);
            this.LogOutbutton1.TabIndex = 3;
            this.LogOutbutton1.Text = "Logga ut";
            this.LogOutbutton1.UseVisualStyleBackColor = true;
            this.LogOutbutton1.Click += new System.EventHandler(this.LogOutbutton1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Jalla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoggedInEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogOutbutton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountInfobutton1);
            this.Controls.Add(this.CreateEventbutton1);
            this.Name = "LoggedInEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inloggad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateEventbutton1;
        private System.Windows.Forms.Button AccountInfobutton1;
        private System.Windows.Forms.Button LogOutbutton1;
        private System.Windows.Forms.Button button1;
    }
}