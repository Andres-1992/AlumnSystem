using BusinessEntities;
using BusinessEntities.Enums;
using BusinessEntities.Junction;
using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class CreateCampaign : Form
    {
        Services Services { get; set; }

        List<Alumn> Alumns { get; set; }
        SubscriberList SubscriberList { get; set; }
        Campaign Campaign { get; set; }
        Employee Employee { get; set; }
        public CreateCampaign(Services services, Employee employee)
        {
            InitializeComponent();
            Services = services;
            EducationcomboBox.DataSource = Enum.GetValues(typeof(Education));
            Employee = employee;
            Alumns = new List<Alumn>();
        }


        private void showAllBt_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Services.EmployeeServices.GetAll();
            HideColumns1();
        }

        private void Showbutton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Services.EmployeeServices.GetAlumnsByEducation((Education)Enum.Parse(typeof(Education), EducationcomboBox.SelectedValue.ToString()));
            HideColumns1();
        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            Alumn alumn = (Alumn)dataGridView1.CurrentRow.DataBoundItem;

            if (!Alumns.Contains(alumn))
            {
                Alumns.Add(alumn);
            }
            LoadDataGridView2();

            HideColumns2();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            var result = dataGridView2.CurrentRow.DataBoundItem;
            Alumn alumn = (Alumn)result;
            Alumns.Remove(alumn);

            LoadDataGridView2();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void CreatecampaignBT_Click(object sender, EventArgs e)
        {
            Campaign = new Campaign()
            {
                Created = DateTime.Now,
                Creator = Employee,
                Message = richTextBox1.Text,
                Sent = false
            };
            Services.EmployeeServices.AddCampaign(Campaign);
            CampaignSubscribers campaignSubscribers = new CampaignSubscribers() { Campaign = Campaign, SubscriberList = SubscriberList };
            Services.EmployeeServices.AddCampaignSubscribers(campaignSubscribers);

            MessageBox.Show("Du har skapat ett utskick");
            Owner.Show();
        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            SubscriberList = new SubscriberList() { Created = DateTime.Now };
            Services.EmployeeServices.AddSubscriberList(SubscriberList);
            SubscriberListAlumn SubscriberListAlumn = new SubscriberListAlumn();
            foreach (var item in Alumns)
            {
                SubscriberListAlumn.Alumn = item;
                SubscriberListAlumn.SubscriberList = SubscriberList;
                Services.EmployeeServices.AddSubscriberListAlumn(SubscriberListAlumn);
            }
            MessageBox.Show("Du har skapat en ny Subscriber lista");
        }
        private void LoadDataGridView2()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Alumns;          
        }
        private void HideColumns1()
        {
            dataGridView1.Columns["AlumnEvents"].Visible = false;
            dataGridView1.Columns["Competences"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["SubscriberListAlumn"].Visible = false;
        }
        private void HideColumns2()
        {
            dataGridView2.Columns["AlumnEvents"].Visible = false;
            dataGridView2.Columns["Competences"].Visible = false;
            dataGridView2.Columns["Password"].Visible = false;
            dataGridView2.Columns["SubscriberListAlumn"].Visible = false;
        }
    }
}
