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
            this.Editbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1000, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 5, 3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(571, 667);
            this.dataGridView1.TabIndex = 0;
            // 
            // EventTitletextBox
            // 
            this.EventTitletextBox.Location = new System.Drawing.Point(210, 183);
            this.EventTitletextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EventTitletextBox.Name = "EventTitletextBox";
            this.EventTitletextBox.Size = new System.Drawing.Size(360, 31);
            this.EventTitletextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beskrivning";
            // 
            // titelLabel1
            // 
            this.titelLabel1.AutoSize = true;
            this.titelLabel1.Location = new System.Drawing.Point(117, 188);
            this.titelLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titelLabel1.Name = "titelLabel1";
            this.titelLabel1.Size = new System.Drawing.Size(44, 25);
            this.titelLabel1.TabIndex = 2;
            this.titelLabel1.Text = "Titel";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(210, 265);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(360, 284);
            this.DescriptionTextBox.TabIndex = 3;
            this.DescriptionTextBox.Text = "";
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(464, 635);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(107, 38);
            this.Addbutton.TabIndex = 4;
            this.Addbutton.TabStop = false;
            this.Addbutton.Text = "Lägg Till";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Cancelbutton.Location = new System.Drawing.Point(210, 635);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(107, 38);
            this.Cancelbutton.TabIndex = 4;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // StartDatePicker1
            // 
            this.StartDatePicker1.Location = new System.Drawing.Point(629, 183);
            this.StartDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartDatePicker1.Name = "StartDatePicker1";
            this.StartDatePicker1.Size = new System.Drawing.Size(284, 31);
            this.StartDatePicker1.TabIndex = 6;
            // 
            // LastTimePicker
            // 
            this.LastTimePicker.Location = new System.Drawing.Point(629, 348);
            this.LastTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastTimePicker.Name = "LastTimePicker";
            this.LastTimePicker.Size = new System.Drawing.Size(284, 31);
            this.LastTimePicker.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sista anmälningsdatum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start datum";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Location = new System.Drawing.Point(629, 265);
            this.EndDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(284, 31);
            this.EndDatePicker.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Slut datum";
            // 
            // Editbutton1
            // 
            this.Editbutton1.Location = new System.Drawing.Point(807, 635);
            this.Editbutton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Editbutton1.Name = "Editbutton1";
            this.Editbutton1.Size = new System.Drawing.Size(107, 38);
            this.Editbutton1.TabIndex = 9;
            this.Editbutton1.Text = "Redigera";
            this.Editbutton1.UseVisualStyleBackColor = true;
            this.Editbutton1.Click += new System.EventHandler(this.Editbutton1_Click);
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 750);
            this.Controls.Add(this.Editbutton1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Editbutton1;
    }
}