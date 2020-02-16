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
        BusinessManager bm = new BusinessManager();
        Employee employee;
        public AddEvent()
        {
            InitializeComponent();
        }
        public AddEvent(Employee e)
        {
            InitializeComponent();
            employee = e;
        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            DateTime StartDate = StartDatePicker1.Value.Date;
            DateTime EndDate = EndDatePicker.Value.Date;
            DateTime LastApplyingDate = LastTimePicker.Value.Date;            

            Event events = new Event(EventTitletextBox.Text, DescriptionTextBox.Text, StartDate, EndDate, LastApplyingDate, 1);
                bm.AddEvent(events);

            MessageBox.Show("Ajde");
            this.Close();
            
        }
    }

}
