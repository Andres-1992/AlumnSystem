using BusinessEntities;
using BusinessEntities.Enums;
using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class UpdateAlumn : Form
    {
        Alumn alumn;
        BusinessManager businessManager;
        List<Competence> competences;
        public UpdateAlumn()
        {
            InitializeComponent();
        }
        public UpdateAlumn(BusinessManager bm,Alumn a)
        {
            InitializeComponent();
            businessManager = bm;
            alumn = a;
            competences = businessManager.GetCompetences(alumn).ToList();
            LoadInfo();
            LoadCompetences();
            this.Text = alumn.Name;
        }
        #region load metoder
        private void LoadInfo()
        {
            var names = alumn.Name.Split(' ');

            FirstNametextBox.Text = names[0];
            for (int i = 1; i < names.Length; i++)
            {
                SurNametextBox.Text += names[i] + " ";
            }

            LoadCompetences();
            LevelcomboBox.DataSource = Enum.GetValues(typeof(CompetenceLevel));
        }

        private void LoadCompetences()
        {
            EmailtextBox.Text = alumn.Email;
            PhoneNumbertextBox.Text = alumn.Phonenumber;
            listView1.Items.Clear();
            foreach (var item in competences)
            {
                var rad = new string[] { item.Description, item.CompetenceLevel.ToString() };
                var listView = new ListViewItem(rad);
                listView1.Items.Add(listView);
            }
        }
        #endregion
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void Applybutton_Click(object sender, EventArgs e)
        {
            string fullname = FirstNametextBox.Text + " " + SurNametextBox.Text;
            alumn.Name = fullname;
            alumn.Email = EmailtextBox.Text;
            alumn.Phonenumber = PhoneNumbertextBox.Text;
            alumn.Competences = competences;
            businessManager.UpdateAlumn(alumn);
            MessageBox.Show("Dina uppgifter är uppdaterade");
        }

        private void AddNewExpButton_Click(object sender, EventArgs e)
        {
            CompetenceLevel competenceLevel;
            Enum.TryParse<CompetenceLevel>(LevelcomboBox.SelectedValue.ToString(), out competenceLevel);

            Competence competence = new Competence(ExperienceRichTextBox.Text, competenceLevel);
            competences.Add(competence);
            MessageBox.Show("Du har lagt till en ny kompetens");
            ExperienceRichTextBox.Clear();
            LoadCompetences();
        }
    }
}
