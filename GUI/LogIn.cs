using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities;
using BusinessEntities.Models;
using BusinessLayer;
namespace GUI
{
    public partial class LogIn : Form
    {
        BusinessManager businessmanager;
        public LogIn()
        {
            InitializeComponent();
            businessmanager = new BusinessManager();
        }
        /// <summary>
        /// Ändrar namnet på username text box beroende på vilken radiobutton som är markerad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        private void logInButton_Click(object sender, EventArgs e)
        {
            string lösenordhacker = BusinessManager.Encrypt(passwordTextBox.Text);

            if (ValidateTextBoxes()&&alumnRadioButton.Checked)
            {
                Alumn a = businessmanager.LogInAlumn(userNameTextBox.Text, lösenordhacker);
                if (a != null)
                {
                    LoggedInAlumn loggedIn = new LoggedInAlumn(businessmanager, a);                    
                    this.Hide();
                    loggedIn.ShowDialog(this);
                    ClearTextboxes();
                }
                else
                {
                    MessageBox.Show("bror börja om");
                }
            }
            else if (ValidateTextBoxes()&&personalRadioButton.Checked)
            {
                Employee employee = businessmanager.LogInEmployee(userNameTextBox.Text,lösenordhacker);
                if (employee!=null)
                {
                    LoggedInEmployee loggedIn = new LoggedInEmployee(businessmanager,employee);
                    this.Hide();
                    loggedIn.ShowDialog(this);
                    ClearTextboxes();
                }
                 else
                {
                    MessageBox.Show("bror börja om");
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
            Registrering_Alumn ra = new Registrering_Alumn();
            this.Hide() ;           
            ra.ShowDialog(this);
        }
        #region hjälpmetoder för textboxes
        /// <summary>
        /// Går igenom alla controller i denna form. Fångar alla textboxar och validerar om 
        /// dom har text. returnerar bool
        /// </summary>
        /// <returns></returns>
        private  bool ValidateTextBoxes()
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
