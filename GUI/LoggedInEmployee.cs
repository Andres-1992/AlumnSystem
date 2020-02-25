using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoggedInEmployee : Form
    {
        Employee employee { get; set; }
        Services Services { get; set; }

        public LoggedInEmployee()
        {
            InitializeComponent();
        }

        public LoggedInEmployee(Services services, Employee e)
        {
            InitializeComponent();
            Services = services;
            employee = e;
        }

        private void CreateEventbutton1_Click(object sender, EventArgs e)
        {
            AddEvent addevent = new AddEvent(Services, employee);
            this.Hide();
            addevent.ShowDialog(this);
        }

        private void LogOutbutton1_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void AccountInfobutton1_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee(Services, employee);
            this.Hide();
            updateEmployee.ShowDialog(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCampaign createCampaign = new CreateCampaign(Services, employee);
            this.Hide();
            createCampaign.ShowDialog(this);
        }
    }
}
