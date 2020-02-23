using BusinessEntities.Enums;
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
    public partial class AddEvent : Form
    {
        Services Services { get; set; }
        Employee employee { get; set; }

        public AddEvent()
        {
            InitializeComponent();

        }
        public AddEvent(Services services, Employee e)
        {
            InitializeComponent();
            Services = services;
            employee = e;
            dataGridView1.DataSource = services.BusinessManager.GetEvent();
        }


        private void Addbutton1_Click(object sender, EventArgs e)
        {
            DateTime StartDate = StartDatePicker1.Value.Date;
            DateTime EndDate = EndDatePicker.Value.Date;
            DateTime LastApplyingDate = LastTimePicker.Value.Date;
            if (LastApplyingDate < StartDate && StartDate < EndDate)
            {
                Event events = new Event(EventTitletextBox.Text, DescriptionTextBox.Text, StartDate, EndDate, LastApplyingDate, employee.EmployeeId);
                Services.EmployeeServices.AddEvent(events);
                MessageBox.Show("Event tillagd");
                dataGridView1.DataSource = Services.BusinessManager.GetEvent();
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void Editbutton1_Click(object sender, EventArgs e)
        {
            var result = dataGridView1.CurrentRow.DataBoundItem;
            Event obj = (Event)result;
            EditEvent editevent = new EditEvent(Services, obj);
            this.Hide();
            editevent.ShowDialog(this);


        }

    }

}
