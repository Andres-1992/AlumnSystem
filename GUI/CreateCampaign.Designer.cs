namespace GUI
{
    partial class CreateCampaign
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Showbutton1 = new System.Windows.Forms.Button();
            this.EducationcomboBox = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.showAllBt = new System.Windows.Forms.Button();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.Createbutton = new System.Windows.Forms.Button();
            this.CreatecampaignBT = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1364, 325);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.MultiSelect = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 523);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(950, 325);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.MultiSelect = false;
            // 
            // Showbutton1
            // 
            this.Showbutton1.Location = new System.Drawing.Point(963, 378);
            this.Showbutton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Showbutton1.Name = "Showbutton1";
            this.Showbutton1.Size = new System.Drawing.Size(107, 42);
            this.Showbutton1.TabIndex = 1;
            this.Showbutton1.Text = "Visa";
            this.Showbutton1.UseVisualStyleBackColor = true;
            this.Showbutton1.Click += new System.EventHandler(this.Showbutton1_Click);
            // 
            // EducationcomboBox
            // 
            this.EducationcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EducationcomboBox.DropDownWidth = 150;
            this.EducationcomboBox.FormattingEnabled = true;
            this.EducationcomboBox.Location = new System.Drawing.Point(702, 335);
            this.EducationcomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EducationcomboBox.Name = "EducationcomboBox";
            this.EducationcomboBox.Size = new System.Drawing.Size(368, 33);
            this.EducationcomboBox.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(963, 523);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(388, 325);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(1115, 493);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(111, 25);
            this.messageLabel.TabIndex = 4;
            this.messageLabel.Text = "Meddelande";
            // 
            // showAllBt
            // 
            this.showAllBt.Location = new System.Drawing.Point(963, 430);
            this.showAllBt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showAllBt.Name = "showAllBt";
            this.showAllBt.Size = new System.Drawing.Size(107, 38);
            this.showAllBt.TabIndex = 5;
            this.showAllBt.Text = "Visa alla";
            this.showAllBt.UseVisualStyleBackColor = true;
            this.showAllBt.Click += new System.EventHandler(this.showAllBt_Click);
            // 
            // Addbutton1
            // 
            this.Addbutton1.Location = new System.Drawing.Point(15, 335);
            this.Addbutton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(107, 38);
            this.Addbutton1.TabIndex = 6;
            this.Addbutton1.Text = "Lägg till";
            this.Addbutton1.UseVisualStyleBackColor = true;
            this.Addbutton1.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // Createbutton
            // 
            this.Createbutton.Location = new System.Drawing.Point(693, 858);
            this.Createbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(107, 38);
            this.Createbutton.TabIndex = 8;
            this.Createbutton.Text = "Skapa Lista";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // CreatecampaignBT
            // 
            this.CreatecampaignBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CreatecampaignBT.Location = new System.Drawing.Point(1230, 862);
            this.CreatecampaignBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreatecampaignBT.Name = "CreatecampaignBT";
            this.CreatecampaignBT.Size = new System.Drawing.Size(121, 36);
            this.CreatecampaignBT.TabIndex = 9;
            this.CreatecampaignBT.Text = "Skapa";
            this.CreatecampaignBT.UseVisualStyleBackColor = true;
            this.CreatecampaignBT.Click += new System.EventHandler(this.CreatecampaignBT_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CancelButton.Location = new System.Drawing.Point(963, 858);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(121, 38);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Avbryt";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(12, 856);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(112, 34);
            this.Deletebutton.TabIndex = 11;
            this.Deletebutton.Text = "Ta bort";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // CreateCampaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1364, 910);
            this.Controls.Add(this.Createbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CreatecampaignBT);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.showAllBt);
            this.Controls.Add(this.Showbutton1);
            this.Controls.Add(this.EducationcomboBox);
            this.Controls.Add(this.Addbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateCampaign";
            this.Text = "Campaign";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Showbutton1;
        private System.Windows.Forms.ComboBox EducationcomboBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button showAllBt;
        private System.Windows.Forms.Button Addbutton1;
        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.Button CreatecampaignBT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button Deletebutton;
    }
}