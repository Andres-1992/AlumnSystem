using BusinessEntities;
using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoggedInAlumn : Form
    {
        Alumn alumn;
        AlumnService alumnService;
        public LoggedInAlumn()
        {            
            InitializeComponent();            
        }

        public LoggedInAlumn(Alumn a)
        {
            InitializeComponent();
            alumnService = new AlumnService();
            alumn = a;
            this.Text = alumn.Name;
        }

        private void LogOutbutton2_Click(object sender, EventArgs e)
        {
           Owner.Show();
        }

        private void Attendbutton1_Click(object sender, EventArgs e)
        {
            AttendEvent attendEvent = new AttendEvent(alumnService,alumn);
            this.Hide();
            attendEvent.ShowDialog(this);
            
        }

        private void AccountInfobutton2_Click(object sender, EventArgs e)
        {
            UpdateAlumn updateAlumn = new UpdateAlumn(alumnService,alumn);
            this.Hide();
            updateAlumn.ShowDialog(this); 
        }
    }
}
