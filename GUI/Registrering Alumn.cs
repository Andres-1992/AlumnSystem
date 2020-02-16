using BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using System.Security.Cryptography;
namespace GUI
{
    public partial class Registrering_Alumn : Form
    {
        LogIn login;
        BusinessManager businessManager;
        public Registrering_Alumn()
        {
            InitializeComponent();
        }

        public Registrering_Alumn(BusinessManager bm)
        {

            InitializeComponent();
            businessManager = bm;
        }


        private void lösenordTB_TextChanged(object sender, EventArgs e)
        {
            pwTextb.UseSystemPasswordChar = true;
        }

        private void showPWCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPWCheckbox.Checked) pwTextb.UseSystemPasswordChar = false;
            else pwTextb.UseSystemPasswordChar = true;
        }

        private void showPW2checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPW2checkbox.Checked) confirmPwTextb.UseSystemPasswordChar = false;
            else confirmPwTextb.UseSystemPasswordChar = true;
        }

        private void blösenordTB_TextChanged(object sender, EventArgs e)
        {
            confirmPwTextb.UseSystemPasswordChar = true;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            string fullname = firstNameTextb.Text + " " + surNameTextb.Text;
            string lösenordhacker = BusinessManager.Encrypt(pwTextb.Text);
            Alumn alumn = new Alumn(fullname, emailTextb.Text, phoneNrTextb.Text, educationComboBox.Text, lösenordhacker);
            businessManager.AddAlumn(alumn);

            MessageBox.Show(pwTextb.Text);
            alumn = null;
            this.Close();
            //login = new LogIn();
            //login.Show();
            
            Owner.Show();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNameTextb.Clear();
            surNameTextb.Clear();
            emailTextb.Clear();
            phoneNrTextb.Clear();
            pwTextb.Clear();
            confirmPwTextb.Clear();
        }


    }
}
