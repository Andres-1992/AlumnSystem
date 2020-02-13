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
        public AddEvent()
        {
            InitializeComponent();
        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            DateTime StartDate = StartDatumPicker1.Value.Date;
            DateTime EndDate = SlutDatumPicker1.Value.Date;
            DateTime LastApplyingDate = LastTimePicker2.Value.Date;
            
            int employeeIdtextBox2 = int.Parse(employeeIdtextBox1.Text);
            

            Event events = new Event(EventTitletextBox1.Text, DescriptionTextBox1.Text, StartDate, EndDate, LastApplyingDate, 1);
                bm.AddEvent(events);

            MessageBox.Show("Ajde");
            this.Close();
            
        }
    }

}
