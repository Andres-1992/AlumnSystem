using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Editevent : Form
    {
        Event events;
        public Editevent()
        {
            InitializeComponent();

        }

        public  Editevent(Event ev)
        {
            InitializeComponent();
            events = ev;
            LoadEventInfo();
        }
        public void LoadEventInfo()
        {
            richTextBox1.Text = events.Description;
            textBox6.Text = events.Title;
            startTimePicker1.Value = events.StartDate;
            endTimePicker1.Value = events.EndDate;
            lastTimePicker1.Value = events.LastApplyingDate;

        }
        private void Editbutton1_Click(object sender, EventArgs e)
        {
            
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {

        }

    }
}
