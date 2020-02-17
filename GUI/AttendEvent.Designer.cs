namespace GUI
{
    partial class AttendEvent
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
            this.AvailableEventlabel1 = new System.Windows.Forms.Label();
            this.Applybutton1 = new System.Windows.Forms.Button();
            this.Cancelbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1024, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // AvailableEventlabel1
            // 
            this.AvailableEventlabel1.AutoSize = true;
            this.AvailableEventlabel1.Location = new System.Drawing.Point(41, 36);
            this.AvailableEventlabel1.Name = "AvailableEventlabel1";
            this.AvailableEventlabel1.Size = new System.Drawing.Size(101, 15);
            this.AvailableEventlabel1.TabIndex = 1;
            this.AvailableEventlabel1.Text = "Tillgängliga event";
            // 
            // Applybutton1
            // 
            this.Applybutton1.Location = new System.Drawing.Point(274, 358);
            this.Applybutton1.Name = "Applybutton1";
            this.Applybutton1.Size = new System.Drawing.Size(75, 23);
            this.Applybutton1.TabIndex = 2;
            this.Applybutton1.Text = "Delta";
            this.Applybutton1.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton1
            // 
            this.Cancelbutton1.Location = new System.Drawing.Point(41, 358);
            this.Cancelbutton1.Name = "Cancelbutton1";
            this.Cancelbutton1.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton1.TabIndex = 3;
            this.Cancelbutton1.Text = "Avbryt";
            this.Cancelbutton1.UseVisualStyleBackColor = true;
            // 
            // AttendEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancelbutton1);
            this.Controls.Add(this.Applybutton1);
            this.Controls.Add(this.AvailableEventlabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AttendEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delta i event";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AvailableEventlabel1;
        private System.Windows.Forms.Button Applybutton1;
        private System.Windows.Forms.Button Cancelbutton1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}