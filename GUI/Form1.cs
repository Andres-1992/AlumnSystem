using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
namespace GUI
{
    public partial class Form1 : Form
    {
        BusinessManager bm;
        public Form1()
        {
            InitializeComponent();
            bm = new BusinessManager();
        }

        private void personalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (personalRadioButton.Checked)
            {
                idLabel.Text = "Signatur";
            }
            else
            {
                idLabel.Text = "Email";
            }
        }
        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string lösenordhacker = BusinessManager.Encrypt(passwordTextBox.Text);
            
            
            if (bm.LogIn(username, lösenordhacker) != null)
            {
                MessageBox.Show("jalla klar");
            }
            else
            {
                MessageBox.Show("bror börja om");
            }

            
        }

       

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrering_Alumn ra = new Registrering_Alumn();
            this.Hide();
            ra.ShowDialog(this);
           
        }
    }
}
