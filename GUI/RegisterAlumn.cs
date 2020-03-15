using BusinessEntities.Enums;
using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class Registrering_Alumn : Form
    {
        List<Competence> competences { get; set; }
        Services Services { get; set; }
        public Registrering_Alumn(Services services)
        {
            InitializeComponent(); 
            Services = services;
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
            string encryptedPassword = Services.LogInServices.Encrypt(pwTextb.Text);


            if (ValidateTextBoxes())
            {
                if (pwTextb.Text == confirmPwTextb.Text)
                {
                    Alumn alumn = new Alumn(fullname,
                        emailTextb.Text,
                        phoneNrTextb.Text,
                        (Education)Enum.Parse(typeof(Education), educationComboBox.SelectedValue.ToString()),
                        encryptedPassword,
                        workCheckbox.Checked);
                    alumn.Competences = competences;
                    Services.AddServices.AddAlumn(alumn);
                    MessageBox.Show("Du är registrerad");
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
            competenceRichTextBox.Clear();
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
            else registerButton.Enabled = false;
        }

        private void AddCompetence_Click(object sender, EventArgs e)
        {        
            Competence competence = new Competence(competenceRichTextBox.Text,
                (CompetenceLevel)Enum.Parse(typeof(CompetenceLevel), competenceComboBox.SelectedValue.ToString()));
            competences.Add(competence);
            MessageBox.Show("Du har lagt till " + competences.Count + " kompetens(er)");
            competenceRichTextBox.Clear();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void competenceRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(competenceRichTextBox.Text)) AddCompetence.Enabled = false;
            else AddCompetence.Enabled = true;
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
