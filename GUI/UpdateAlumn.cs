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
        Alumn alumn { get; set; }
        Services Services { get; set; }
        List<Competence> competences { get; set; }
        public UpdateAlumn()
        {
            InitializeComponent();
        }
        public UpdateAlumn(Services services, Alumn a)
        {
            InitializeComponent();
            Services = services;
            alumn = a;
            LoadInfo();
            LoadCompetences();
            LevelcomboBox.DataSource = Enum.GetValues(typeof(CompetenceLevel));
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
            EmailtextBox.Text = alumn.Email;
            PhoneNumbertextBox.Text = alumn.Phonenumber;
            competences = Services.AlumnServices.GetCompetences(alumn).ToList();
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
            Services.AlumnServices.UpdateAlumn(alumn);
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




            //if (listView1.SelectedItems.Count == 0)
            //    return;

            //ListViewItem item = listView1.SelectedItems[0];

            //Alumn test = Services.AlumnServices.GetById(int.Parse(item.Text));

            //List<Alumn> alumner = new List<Alumn>();

            //MessageBox.Show(test.Name);
            
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ////fill the text boxes
            //textBoxID.Text = item.Text;
            //textBoxName.Text = item.SubItems[0].Text;
            //textBoxPhone.Text = item.SubItems[1].Text;
            //textBoxLevel.Text = item.SubItems[2].Text;
        }
    }
}
