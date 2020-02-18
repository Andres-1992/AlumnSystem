using System.Windows.Forms;
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
           
            this.Applybutton1 = new System.Windows.Forms.Button();
            this.Cancelbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1265, 497);
            this.dataGridView1.TabIndex = 0;

            // 
            // Applybutton1
            // 
            this.Applybutton1.Location = new System.Drawing.Point(391, 597);
            this.Applybutton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Applybutton1.Name = "Applybutton1";
            this.Applybutton1.Size = new System.Drawing.Size(107, 38);
            this.Applybutton1.TabIndex = 2;
            this.Applybutton1.Text = "Delta";
            this.Applybutton1.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton1
            // 
            this.Cancelbutton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Cancelbutton1.Location = new System.Drawing.Point(59, 597);
            this.Cancelbutton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancelbutton1.Name = "Cancelbutton1";
            this.Cancelbutton1.Size = new System.Drawing.Size(107, 38);
            this.Cancelbutton1.TabIndex = 3;
            this.Cancelbutton1.Text = "Avbryt";
            this.Cancelbutton1.UseVisualStyleBackColor = true;
            this.Cancelbutton1.Click += new System.EventHandler(this.Cancelbutton1_Click);
            // 
            // AttendEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 677);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cancelbutton1);
            this.Controls.Add(this.Applybutton1);
            
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AttendEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delta i event";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Applybutton1;
        private System.Windows.Forms.Button Cancelbutton1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}