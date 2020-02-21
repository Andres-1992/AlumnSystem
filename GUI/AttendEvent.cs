using BusinessEntities;
using BusinessEntities.Models;
using BusinessLayer;
using DataLayer.Contexts.Junction;
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
        Alumn alumn { get; set; }
        Services Services { get; set; }
       
        public AttendEvent()
        {
            InitializeComponent();
           
        }

        public AttendEvent(Services services, Alumn a)
        {
            InitializeComponent();
            alumn = a;
            Services = services;
            dataGridView1.DataSource = services.BusinessManager.GetEvent();
            dataGridView2.DataSource = services.AlumnServices.GetAttendedEvent(alumn); 
            
            HideColumns();            
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void Applybutton1_Click(object sender, EventArgs e)
        {
            var result = dataGridView1.CurrentRow.DataBoundItem;
            Event obj = (Event)result;
            AlumnEvent AE = new AlumnEvent() { Alumn = alumn, Event = obj  };
            Services.AlumnServices.AddAlumnEvent(AE);
            MessageBox.Show("Du har registrerat dig på eventet: " + obj.Title);
            dataGridView2.DataSource = Services.AlumnServices.GetAttendedEvent(alumn);

        }     
        
        public void HideColumns()
        {
            dataGridView1.Columns["AlumnEvents"].Visible = false;
            dataGridView1.Columns["Employee"].Visible = false;
            dataGridView2.Columns["EmployeeId"].Visible = false;
            dataGridView2.Columns["AlumnEvents"].Visible = false;
            dataGridView2.Columns["Employee"].Visible = false;
           
        }
    }
}
