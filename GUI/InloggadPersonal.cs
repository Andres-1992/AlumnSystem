using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class InloggadPersonal : Form
    {
        public InloggadPersonal()
        {
            InitializeComponent();
        }

        private void CreateEventbutton1_Click(object sender, EventArgs e)
        {
            AddEvent addevent = new AddEvent();
            addevent.Show();
            this.Hide();
        }

        private void LogOutbutton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            
            
        }

        private void AccountInfobutton1_Click(object sender, EventArgs e)
        {
            ÄndraPersonalUppgifter personaluppgifter = new ÄndraPersonalUppgifter();
            personaluppgifter.Show();
            this.Hide();

        }
    }
}
