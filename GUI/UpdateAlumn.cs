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
        AlumnService alumnService;
        List<Competence> competences;
        public UpdateAlumn()
        {
            InitializeComponent();
        }
        public UpdateAlumn(AlumnService aService ,Alumn a)
        {
            InitializeComponent();
            alumnService = aService;
            alumn = a;
            competences = alumnService.GetCompetences(alumn).ToList();
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
            alumnService.UpdateAlumn(alumn);
            MessageBox.Show("Dina uppgifter är uppdaterade");
        }

        private void AddNewExpButton_Click(object sender, EventArgs e)
        {
            CompetenceLevel competenceLevel;
            Enum.TryParse<CompetenceLevel>(LevelcomboBox.SelectedValue.ToString(), out competenceLevel);

            Competence competence = new Competence(ExperienceRichTextBox.Text, competenceLevel);
            competences.Add(competence);
            MessageBox.Show("Du har lagt till en ny kompetens"); 
            
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView1.SelectedItems[0];
           
            Alumn test = alumnService.GetById(int.Parse(item.Text));

            List<Alumn> alumner = new List<Alumn>();

            MessageBox.Show(test.Name);
            ExperienceRichTextBox.Clear();
            LoadCompetences();
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
