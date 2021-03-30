using BusinessEntities.Enums;
using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class UpdateAlumn : Form
    {
        Alumn Alumn { get; set; }
        Services Services { get; set; }
        List<Competence> competences { get; set; }
        public UpdateAlumn()
        {
            InitializeComponent();
        }
        public UpdateAlumn(Services services, Alumn alumn)
        {
            InitializeComponent();
            Services = services;
            Alumn = alumn;
            LoadInfo();
            LoadCompetences();
            LevelcomboBox.DataSource = Enum.GetValues(typeof(CompetenceLevel));
            this.Text = Alumn.Name;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void Applybutton_Click(object sender, EventArgs e)
        {
            string fullname = FirstNametextBox.Text + " " + SurNametextBox.Text;
            Alumn.Name = fullname;
            Alumn.Email = EmailtextBox.Text;
            Alumn.Phonenumber = PhoneNumbertextBox.Text;
            Alumn.Competences = competences;
            Services.UpdateServices.UpdateAlumn(Alumn);
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

        #region Load metoder
        private void LoadInfo()
        {
            var names = Alumn.Name.Split(' ');

            FirstNametextBox.Text = names[0];
            for (int i = 1; i < names.Length; i++)
            {
                SurNametextBox.Text += names[i] + " ";
            }
            EmailtextBox.Text = Alumn.Email;
            PhoneNumbertextBox.Text = Alumn.Phonenumber;
            competences = Services.GetCollectionServices.GetCompetences(Alumn).ToList();
            LoadCompetences();

        }

        private void LoadCompetences()
        {

            listView1.Items.Clear();
            foreach (var item in competences)
            {
                var rad = new string[] { item.Description, item.CompetenceLevel.ToString() };
                var listView = new ListViewItem(rad);
                listView1.Items.Add(listView);
            }

        }
        #endregion
    }
}
