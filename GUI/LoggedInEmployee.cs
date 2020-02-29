using BusinessEntities.Models;
using BusinessEntities.ObserverPattern;
using BusinessLayer;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoggedInEmployee : Form , IObserver
    {
        Employee Employee { get; set; }
        Services Services { get; set; }

        public void Update(ISubject subject)
        {
            if (subject is AddEvent evnt)
            {
                label2.Visible = true;
                label2.Text = "Det finns nu " + evnt.Counter + " event";
            }
        }

        public LoggedInEmployee(Services services, Employee e)
        {
            InitializeComponent();
            Services = services;
            Employee = e;
        }

        private void CreateEventbutton1_Click(object sender, EventArgs e)
        {
            AddEvent addevent = new AddEvent(Services, Employee);
            addevent.Register(this);
           // this.Hide();
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
