using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoggedInAlumn : Form
    {
        Alumn Alumn { get; set; }
        Services Services { get; set; }
        public LoggedInAlumn()
        {
            InitializeComponent();
        }

        public LoggedInAlumn(Services services, Alumn alumn)
        {
            InitializeComponent();
            Services = services;
            Alumn = alumn;
            this.Text = Alumn.Name;
        }

        private void LogOutbutton2_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void Attendbutton1_Click(object sender, EventArgs e)
        {
            AttendEvent attendEvent = new AttendEvent(Services, Alumn);
            this.Hide();
            attendEvent.ShowDialog(this);

        }

        private void AccountInfobutton2_Click(object sender, EventArgs e)
        {
            UpdateAlumn updateAlumn = new UpdateAlumn(Services, Alumn);
            this.Hide();
            updateAlumn.ShowDialog(this);
        }

        private void DeleteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteAccount deleteAccount = new DeleteAccount(Services, Alumn);
            this.Hide();
            deleteAccount.ShowDialog(this);
            if (deleteAccount.DialogResult == DialogResult.Yes)  Owner.Show();
        }
    }
}
