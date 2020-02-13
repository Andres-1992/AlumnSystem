using BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;

namespace GUI
{
    public partial class Registrering_Alumn : Form
    {
        BusinessManager bm = new BusinessManager();
        public Registrering_Alumn()
        {
            InitializeComponent();            
        }

        private void lösenordTB_TextChanged(object sender, EventArgs e)
        {
            lösenordTB.UseSystemPasswordChar = true;
        }

        private void showPWCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPWCheckbox.Checked) lösenordTB.UseSystemPasswordChar = false;
            else lösenordTB.UseSystemPasswordChar = true;
        }

        private void showPW2checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPW2checkbox.Checked) blösenordTB.UseSystemPasswordChar = false;
            else blösenordTB.UseSystemPasswordChar = true;
        }

        private void blösenordTB_TextChanged(object sender, EventArgs e)
        {
            blösenordTB.UseSystemPasswordChar = true;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string fullname = namnTB.Text + " " + enamnTB.Text;
           Alumn alumn = new Alumn(fullname,emailTB.Text,tlfnnrTB.Text,utbildningCBox.Text,lösenordTB.Text);
            bm.AddAlumn(alumn);

            MessageBox.Show("jalla klar");
            this.Close();
            Owner.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            namnTB.Clear();
            enamnTB.Clear();
            emailTB.Clear();
            tlfnnrTB.Clear();
            lösenordTB.Clear();
            blösenordTB.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
