using BusinessEntities;
using BusinessLayer;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoggedInAlumn : Form
    {
        Alumn alumn { get; set; }
        Services Services { get; set; }
        public LoggedInAlumn()
        {
            InitializeComponent();
        }

        public LoggedInAlumn(Services services, Alumn a)
        {
            InitializeComponent();
            Services = services;
            alumn = a;
            this.Text = alumn.Name;
        }

        private void LogOutbutton2_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void Attendbutton1_Click(object sender, EventArgs e)
        {
            AttendEvent attendEvent = new AttendEvent(Services, alumn);
            this.Hide();
            attendEvent.ShowDialog(this);

        }

        private void AccountInfobutton2_Click(object sender, EventArgs e)
        {
            UpdateAlumn updateAlumn = new UpdateAlumn(Services, alumn);
            this.Hide();
            updateAlumn.ShowDialog(this);
        }

        private void DeleteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteAccount deleteAccount = new DeleteAccount(Services, alumn);
            this.Hide();
            deleteAccount.ShowDialog();
            if (deleteAccount.DialogResult == DialogResult.OK)
            {
                Owner.Show();
            }
        }
    }
}
