﻿using BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using System.Security.Cryptography;
using BusinessEntities.Enums;
using BusinessEntities.Models;

namespace GUI
{
    public partial class Registrering_Alumn : Form
    {
        List<Competence> competences;
        BusinessManager businessManager;
        public Registrering_Alumn()
        {
            InitializeComponent();
            businessManager = new BusinessManager();
            competences = new List<Competence>();
            educationComboBox.DataSource = Enum.GetValues(typeof(Education));
            competenceComboBox.DataSource = Enum.GetValues(typeof(CompetenceLevel));
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
                    alumn.Competences = competences;
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


        private void GDPRcheckbox_CheckedChanged(object sender, EventArgs e)
        {

            if (GDPRcheckbox.Checked)
            {
             registerButton.Enabled = true;
                MessageBox.Show("Genom att kryssa i rutan samtycker du till att Högskolan i Borås," +
                    " behandlar personuppgifter om dig, i enlighet med vår integritetspolicy. Vi använder uppgifter om dig för att kunna nå dig med information," +
                    " erbjudanden och relevant innehåll. Du kan närsomhelst avregistrera dig från dessa.", "Viktig information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else {  
                registerButton.Enabled = false; 
                
            }
        }

        private void GDPRlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception )
            {

                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            GDPRlink.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("http://www.microsoft.com");
        }
        private void AddCompetence_Click(object sender, EventArgs e)
        { 
            var result = competenceComboBox.SelectedItem;
            CompetenceLevel competenceLevel = (CompetenceLevel)result;
            
            Competence competence = new Competence(competenceRichTextBox.Text,competenceLevel);
            competences.Add(competence);
            competenceRichTextBox.Clear();
        }
    }
}
