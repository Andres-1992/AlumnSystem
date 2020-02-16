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
        BusinessManager businessManager;
        public Registrering_Alumn()
        {
            InitializeComponent();
            businessManager = new BusinessManager();
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

            if (ValidateTextBoxes())
            {
                if (pwTextb.Text == confirmPwTextb.Text)
                {
                    Alumn alumn = new Alumn(fullname, emailTextb.Text, phoneNrTextb.Text, educationComboBox.Text, lösenordhacker, workCheckbox.Checked);

                    businessManager.AddAlumn(alumn);
                    MessageBox.Show(pwTextb.Text);
                    this.Close();
                    Owner.Show();
                }

                else MessageBox.Show("Lösenord matchar inte varandra");

            }
            else
            {
                MessageBox.Show("Alla fält är inte ifyllda");
            }
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

        private bool ValidateTextBoxes()
        {
            try
            {
                string textBoxData = string.Empty;

                foreach (Control item in this.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {

                        if (string.IsNullOrEmpty(item.Text))
                        {
                            return false;
                        }
                        textBoxData += item.Text;
                    }
                }
                return (textBoxData != string.Empty);
            }
            catch { return false; }
        }

    }
}
