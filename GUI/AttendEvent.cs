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
        Alumn alumn;
        AlumnService alumnService;
       
        public AttendEvent()
        {
            InitializeComponent();
           
        }

        public void HideColumns()
        {
            dataGridView1.Columns["AlumnEvents"].Visible = false;
            dataGridView1.Columns["Employee"].Visible = false;

        }
        public AttendEvent(AlumnService aService, Alumn a)
        {
            InitializeComponent();
            alumnService = aService;
            alumn = a;
           dataGridView1.DataSource = new BusinessManager().GetEvent();            
            
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
            AlumnEvent AE = new AlumnEvent() { Event = obj, Alumn = alumn };
          
            alumnService.AddAlumnEvent(AE);
            MessageBox.Show("Du har registrerat dig på eventet: " + obj.Title);
             
        }
    }
}
