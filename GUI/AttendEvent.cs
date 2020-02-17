﻿using BusinessEntities;
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
    public partial class AttendEvent : Form
    {
        Alumn alumn;
        BusinessManager businessManager = new BusinessManager();
       
        public AttendEvent()
        {
            InitializeComponent();
           
        }

        public void HideColumns()
        {
            dataGridView1.Columns["AlumnEvents"].Visible = false;

        }
        public AttendEvent(BusinessManager bm, Alumn a)
        {
            InitializeComponent();
            businessManager = bm;
            alumn = a;
             dataGridView1.DataSource = businessManager.GetEvent();
            HideColumns();
            
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }
    }
}
