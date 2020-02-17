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
    public partial class AttendEvent : Form
    {
        Alumn alumn;
        BusinessManager businessManager = new BusinessManager();
        Event events;
        public AttendEvent()
        {
            InitializeComponent();
            dataGridView1.DataSource = businessManager.GetEvent();
            HideColumns();



        }

        public void HideColumns()
        {
            dataGridView1.Columns["AlumnEvents"].Visible = false;

        }
        public AttendEvent(BusinessManager bm, Alumn a, Event e)
        {
            InitializeComponent();
            businessManager = bm;
            alumn = a;
            events = e;
            this.Text = events.Title;
        }
 


    }
}
