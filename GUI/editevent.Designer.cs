﻿namespace GUI
{
    partial class EditEvent
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
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.endTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lastTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.startTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 632);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Redigera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Editbutton1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(689, 232);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Slut datum";
            // 
            // endTimePicker1
            // 
            this.endTimePicker1.Location = new System.Drawing.Point(609, 262);
            this.endTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endTimePicker1.Name = "endTimePicker1";
            this.endTimePicker1.Size = new System.Drawing.Size(284, 31);
            this.endTimePicker1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(654, 315);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Sista anmälningsdatum";
            // 
            // lastTimePicker1
            // 
            this.lastTimePicker1.Location = new System.Drawing.Point(609, 345);
            this.lastTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastTimePicker1.Name = "lastTimePicker1";
            this.lastTimePicker1.Size = new System.Drawing.Size(284, 31);
            this.lastTimePicker1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(689, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Start datum";
            // 
            // startTimePicker1
            // 
            this.startTimePicker1.Location = new System.Drawing.Point(609, 180);
            this.startTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startTimePicker1.Name = "startTimePicker1";
            this.startTimePicker1.Size = new System.Drawing.Size(284, 31);
            this.startTimePicker1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(190, 632);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Avbryt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(190, 262);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 284);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 262);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Beskrivning";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 185);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Titel";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(190, 180);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(360, 31);
            this.textBox6.TabIndex = 1;
            // 
            // EditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.endTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lastTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.startTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox6);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditEvent";
            this.Text = "Redigera event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker endTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker lastTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker startTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox6;
    }
}