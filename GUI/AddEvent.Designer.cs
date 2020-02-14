namespace GUI
{
    partial class AddEvent
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
            this.EventTitletextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titelLabel1 = new System.Windows.Forms.Label();
            this.DescriptionTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.Cancelbutton1 = new System.Windows.Forms.Button();
            this.StartDatumPicker1 = new System.Windows.Forms.DateTimePicker();
            this.LastTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeIdtextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SlutDatumPicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EventTitletextBox1
            // 
            this.EventTitletextBox1.Location = new System.Drawing.Point(147, 110);
            this.EventTitletextBox1.Name = "EventTitletextBox1";
            this.EventTitletextBox1.Size = new System.Drawing.Size(253, 23);
            this.EventTitletextBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beskrivning";
            // 
            // titelLabel1
            // 
            this.titelLabel1.AutoSize = true;
            this.titelLabel1.Location = new System.Drawing.Point(82, 113);
            this.titelLabel1.Name = "titelLabel1";
            this.titelLabel1.Size = new System.Drawing.Size(30, 15);
            this.titelLabel1.TabIndex = 2;
            this.titelLabel1.Text = "Titel";
            // 
            // DescriptionTextBox1
            // 
            this.DescriptionTextBox1.Location = new System.Drawing.Point(147, 159);
            this.DescriptionTextBox1.Name = "DescriptionTextBox1";
            this.DescriptionTextBox1.Size = new System.Drawing.Size(253, 172);
            this.DescriptionTextBox1.TabIndex = 3;
            this.DescriptionTextBox1.Text = "";
            // 
            // Addbutton1
            // 
            this.Addbutton1.Location = new System.Drawing.Point(325, 381);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(75, 23);
            this.Addbutton1.TabIndex = 4;
            this.Addbutton1.TabStop = false;
            this.Addbutton1.Text = "Lägg Till";
            this.Addbutton1.UseVisualStyleBackColor = true;
            this.Addbutton1.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // Cancelbutton1
            // 
            this.Cancelbutton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Cancelbutton1.Location = new System.Drawing.Point(147, 381);
            this.Cancelbutton1.Name = "Cancelbutton1";
            this.Cancelbutton1.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton1.TabIndex = 4;
            this.Cancelbutton1.Text = "Cancel";
            this.Cancelbutton1.UseVisualStyleBackColor = true;
            this.Cancelbutton1.Click += new System.EventHandler(this.Cancelbutton1_Click);
            // 
            // StartDatumPicker1
            // 
            this.StartDatumPicker1.Location = new System.Drawing.Point(440, 110);
            this.StartDatumPicker1.Name = "StartDatumPicker1";
            this.StartDatumPicker1.Size = new System.Drawing.Size(200, 23);
            this.StartDatumPicker1.TabIndex = 6;
            // 
            // LastTimePicker2
            // 
            this.LastTimePicker2.Location = new System.Drawing.Point(440, 209);
            this.LastTimePicker2.Name = "LastTimePicker2";
            this.LastTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.LastTimePicker2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sista anmälningsdatum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start datum";
            // 
            // employeeIdtextBox1
            // 
            this.employeeIdtextBox1.Location = new System.Drawing.Point(325, 337);
            this.employeeIdtextBox1.Name = "employeeIdtextBox1";
            this.employeeIdtextBox1.Size = new System.Drawing.Size(75, 23);
            this.employeeIdtextBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID";
            // 
            // SlutDatumPicker1
            // 
            this.SlutDatumPicker1.Location = new System.Drawing.Point(440, 159);
            this.SlutDatumPicker1.Name = "SlutDatumPicker1";
            this.SlutDatumPicker1.Size = new System.Drawing.Size(200, 23);
            this.SlutDatumPicker1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Slut datum";
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SlutDatumPicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.employeeIdtextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartDatumPicker1);
            this.Controls.Add(this.Addbutton1);
            this.Controls.Add(this.Cancelbutton1);
            this.Controls.Add(this.DescriptionTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titelLabel1);
            this.Controls.Add(this.EventTitletextBox1);
            this.Name = "AddEvent";
            this.Text = "AddEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EventTitletextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titelLabel1;
        private System.Windows.Forms.RichTextBox DescriptionTextBox1;
        private System.Windows.Forms.Button Addbutton1;
        private System.Windows.Forms.Button Cancelbutton1;
        private System.Windows.Forms.DateTimePicker StartDatumPicker1;
        private System.Windows.Forms.DateTimePicker LastTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employeeIdtextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker SlutDatumPicker1;
        private System.Windows.Forms.Label label5;
    }
}