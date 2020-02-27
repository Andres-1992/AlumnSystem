using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoggedInEmployee : Form
    {
        Employee Employee { get; set; }
        Services Services { get; set; }

        public LoggedInEmployee(Services services, Employee e)
        {
            InitializeComponent();
            Services = services;
            Employee = e;
        }

        private void CreateEventbutton1_Click(object sender, EventArgs e)
        {
            AddEvent addevent = new AddEvent(Services, Employee);
            this.Hide();
            addevent.ShowDialog(this);
        }

        private void LogOutbutton1_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void AccountInfobutton1_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee(Services, Employee);
            this.Hide();
            updateEmployee.ShowDialog(this);

        }

        private void CreateCampaignBT_Click(object sender, EventArgs e)
        {
            CreateCampaign createCampaign = new CreateCampaign(Services, Employee);
            this.Hide();
           createCampaign.ShowDialog(this);
           
        }
    }
}
