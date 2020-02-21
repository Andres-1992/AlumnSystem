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
    public partial class EditEvent : Form
    {
        Services Services { get; set; }
        Event events { get; set; }
        public EditEvent()
        {
            InitializeComponent();

        }

        public  EditEvent(Services services,Event ev)
        {
            InitializeComponent();
            events = ev;
            Services = services;
            LoadEventInfo();
        }
        public void LoadEventInfo()
        {   textBox6.Text = events.Title;
            richTextBox1.Text = events.Description;
            startTimePicker1.Value = events.StartDate;
            endTimePicker1.Value = events.EndDate;
            lastTimePicker1.Value = events.LastApplyingDate;

        }
        private void Editbutton1_Click(object sender, EventArgs e)
        {
            events.Title = textBox6.Text;
            events.Description = richTextBox1.Text;
            events.StartDate = startTimePicker1.Value.Date;
            events.EndDate = endTimePicker1.Value.Date;
            events.LastApplyingDate = lastTimePicker1.Value.Date;
            Services.EmployeeServices.UpdateEvent(events);
            MessageBox.Show("Eventet har uppdaterats");
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

    }
}
