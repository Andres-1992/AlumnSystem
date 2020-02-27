using BusinessEntities;
using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class LogIn : Form
    {
        public Services Services { get; set; }

        public LogIn(Services services)
        {
            InitializeComponent();
            Services = services;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string encryptedPassword = Services.BusinessManager.Encrypt(passwordTextBox.Text);

            if (ValidateTextBoxes() && alumnRadioButton.Checked)
            {
                Alumn alumn = Services.LogInServices.LogInAlumn(userNameTextBox.Text, encryptedPassword);
                if (alumn != null)
                {
                    LoggedInAlumn loggedIn = new LoggedInAlumn(Services, alumn);
                    this.Hide();
                    loggedIn.ShowDialog(this);
                    ClearTextboxes();
                }
                else
                {
                    MessageBox.Show("Du har angivit fel användarnamn/lösenord");
                }
            }
            else if (ValidateTextBoxes() && personalRadioButton.Checked)
            {
                Employee Employee = Services.LogInServices.LogInEmployee(userNameTextBox.Text, encryptedPassword);
                if (Employee != null)
                {
                    LoggedInEmployee loggedIn = new LoggedInEmployee(Services, Employee);
                    this.Hide();
                    loggedIn.ShowDialog(this);
                    ClearTextboxes();
                }
                else
                {
                    MessageBox.Show("Du har angivit fel användarnamn/lösenord");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(userNameTextBox.Text))
                {
                    MessageBox.Show("Du måste fylla i ditt användarnamn");
                }
                if (string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    MessageBox.Show("Du måste fylla i ditt lösenord");
                }
            }
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrering_Alumn registrering_Alumn = new Registrering_Alumn(Services);
            this.Hide();
            registrering_Alumn.ShowDialog(this);
        }

        #region hjälpmetoder för textboxes
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

        private void personalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (personalRadioButton.Checked)
            {
                idLabel.Text = "Signatur";
                userNameTextBox.Text = idLabel.Text;
                registerLinkLabel.Hide();
            }
            else
            {
                idLabel.Text = "Email";
                userNameTextBox.Text = idLabel.Text;
                registerLinkLabel.Show();
            }
        }

        private void userNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            userNameTextBox.SelectAll();
        }

        private void passwordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            passwordTextBox.SelectAll();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }
        private void ClearTextboxes()
        {
            userNameTextBox.Text = idLabel.Text;
            passwordTextBox.Text = passwordLabel.Text;
        }
        #endregion
    }



}
