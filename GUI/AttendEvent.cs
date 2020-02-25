using BusinessEntities;
using BusinessEntities.Models;
using BusinessLayer;
using DataLayer.Contexts.Junction;
using System;
using System.Data;
using System.Linq;
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
            LoadDataGridView();
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void Applybutton1_Click(object sender, EventArgs e)
        {
            var result = dataGridView1.CurrentRow.DataBoundItem;
            Event obj = (Event)result;
            if (!Services.AlumnServices.GetAttendedEvent(alumn).Contains(obj))
            {
                AlumnEvent alumnEvent = new AlumnEvent() { Alumn = alumn, Event = obj };
                Services.AlumnServices.AddAlumnEvent(alumnEvent);
                MessageBox.Show("Du har registrerat dig på eventet: " + obj.Title);
                LoadDataGridView();

            }
            else
            {
                MessageBox.Show("Du har redan registrerat dig på: " + obj.Title);
            }

        }

        private void LoadDataGridView()
        {
            dataGridView1.DataSource = Services.BusinessManager.GetEvent();
            dataGridView2.DataSource = Services.AlumnServices.GetAttendedEvent(alumn);
            HideColumns();
        }
        private void HideColumns()
        {
            dataGridView1.Columns["AlumnEvents"].Visible = false;
            dataGridView1.Columns["Employee"].Visible = false;
            dataGridView2.Columns["EmployeeId"].Visible = false;
            dataGridView2.Columns["AlumnEvents"].Visible = false;
            dataGridView2.Columns["Employee"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = dataGridView2.CurrentRow.DataBoundItem;
            Event obj = (Event)result;
            var result2 = Services.AlumnServices.GetAlumnEvent(alumn).Where(x => x.Event.Equals(obj) && x.Alumn.Equals(alumn)).FirstOrDefault();

            Services.AlumnServices.RemoveMyEvent(result2);
            dataGridView2.DataSource = null;
            LoadDataGridView();
        }
    }
}
