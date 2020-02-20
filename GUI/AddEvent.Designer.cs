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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EventTitletextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titelLabel1 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.StartDatePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LastTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.availableForComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Editbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(700, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 3, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(400, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // EventTitletextBox
            // 
            this.EventTitletextBox.Location = new System.Drawing.Point(147, 110);
            this.EventTitletextBox.Name = "EventTitletextBox";
            this.EventTitletextBox.Size = new System.Drawing.Size(253, 23);
            this.EventTitletextBox.TabIndex = 1;
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
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(147, 159);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(253, 172);
            this.DescriptionTextBox.TabIndex = 3;
            this.DescriptionTextBox.Text = "";
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(325, 381);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 4;
            this.Addbutton.TabStop = false;
            this.Addbutton.Text = "Lägg Till";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Cancelbutton.Location = new System.Drawing.Point(147, 381);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 4;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // StartDatePicker1
            // 
            this.StartDatePicker1.Location = new System.Drawing.Point(440, 110);
            this.StartDatePicker1.Name = "StartDatePicker1";
            this.StartDatePicker1.Size = new System.Drawing.Size(200, 23);
            this.StartDatePicker1.TabIndex = 6;
            // 
            // LastTimePicker
            // 
            this.LastTimePicker.Location = new System.Drawing.Point(440, 209);
            this.LastTimePicker.Name = "LastTimePicker";
            this.LastTimePicker.Size = new System.Drawing.Size(200, 23);
            this.LastTimePicker.TabIndex = 6;
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
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(440, 159);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 23);
            this.EndDatePicker.TabIndex = 6;
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
            // availableForComboBox
            // 
            this.availableForComboBox.FormattingEnabled = true;
            this.availableForComboBox.Location = new System.Drawing.Point(440, 271);
            this.availableForComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.availableForComboBox.Name = "availableForComboBox";
            this.availableForComboBox.Size = new System.Drawing.Size(200, 23);
            this.availableForComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tillgänglig för :";
            // 
            // Editbutton1
            // 
            this.Editbutton1.Location = new System.Drawing.Point(565, 381);
            this.Editbutton1.Name = "Editbutton1";
            this.Editbutton1.Size = new System.Drawing.Size(75, 23);
            this.Editbutton1.TabIndex = 9;
            this.Editbutton1.Text = "Redigera";
            this.Editbutton1.UseVisualStyleBackColor = true;
            this.Editbutton1.Click += new System.EventHandler(this.Editbutton1_Click);
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 450);
            this.Controls.Add(this.Editbutton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.availableForComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartDatePicker1);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titelLabel1);
            this.Controls.Add(this.EventTitletextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEvent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EventTitletextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titelLabel1;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.DateTimePicker StartDatePicker1;
        private System.Windows.Forms.DateTimePicker LastTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox availableForComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Editbutton1;
    }
}