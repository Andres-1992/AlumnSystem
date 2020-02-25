using BusinessEntities;
using BusinessEntities.Enums;
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
            comboBox1.DataSource = Enum.GetValues(typeof(Education));
            Employee = employee;
            Alumns = new List<Alumn>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Services.EmployeeServices.GetAlumnsByEducation((Education)Enum.Parse(typeof(Education), comboBox1.SelectedValue.ToString()));
            HideColumns();
        }

        private void showAllBt_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Services.EmployeeServices.GetAll();
            HideColumns();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            var result = dataGridView1.CurrentRow.DataBoundItem;
            Alumn alumn = (Alumn)result;

            if (!Alumns.Contains(alumn))
            {
                Alumns.Add(alumn);
            }

            LoadDataGridView2();

        }
        private void LoadDataGridView2()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Alumns;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SubscriberList = new SubscriberList() { alumns = Alumns, Created = DateTime.Now };
            MessageBox.Show("Du har skapat en ny Subscriber lista");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Campaign = new Campaign() { subscriberLists = new List<SubscriberList>(), Created = DateTime.Now, Sent = true, Message = richTextBox1.Text, Creator = Employee };
            Campaign.subscriberLists.Add(SubscriberList);
            MessageBox.Show("Du har skickat en utskickslista");
            Owner.Show();
        }
        private void HideColumns()
        {
            dataGridView1.Columns["AlumnEvents"].Visible = false;
            dataGridView1.Columns["Competences"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var result = dataGridView2.CurrentRow.DataBoundItem;
            Alumn alumn = (Alumn)result;
            Alumns.Remove(alumn);

            LoadDataGridView2();
        }
    }
}
