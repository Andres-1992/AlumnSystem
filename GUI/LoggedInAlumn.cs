﻿using BusinessEntities;
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
        BusinessManager businessManager;
        Alumn alumn;
        public LoggedInAlumn()
        {            
            InitializeComponent();            
        }

        public LoggedInAlumn(BusinessManager bm,Alumn a)
        {
            InitializeComponent();
            businessManager = bm;
            alumn = a;
            this.Text = alumn.Name;
        }

        private void LogOutbutton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }

        private void Attendbutton1_Click(object sender, EventArgs e)
        {
            AttendEvent attendEvent = new AttendEvent();
            attendEvent.Show();
            this.Hide();
        }

        private void AccountInfobutton2_Click(object sender, EventArgs e)
        {
            UpdateAlumn updateAlumn = new UpdateAlumn(businessManager,alumn);
            this.Close();
            updateAlumn.Show();
        }
    }
}
