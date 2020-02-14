using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoggedInAlumn : Form
    {
        public LoggedInAlumn()
        {
            InitializeComponent();
            
        }

        private void LogOutbutton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Attendbutton1_Click(object sender, EventArgs e)
        {
            AttendEvent deltaievent = new AttendEvent();
            deltaievent.Show();
            this.Hide();
        }

        private void AccountInfobutton2_Click(object sender, EventArgs e)
        {
            ChangeAlumnInfo alumnuppgifter = new ChangeAlumnInfo();
            alumnuppgifter.Show();
            this.Hide();
        }
    }
}
