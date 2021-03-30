using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class EditEvent : Form
    {
        Services Services { get; set; }
        Event Evnts { get; set; }

        public EditEvent(Services services, Event evnts)
        {
            InitializeComponent();
            Evnts = evnts;
            Services = services;
            LoadEventInfo();
        }
        public void LoadEventInfo()
        {
            textBox6.Text = Evnts.Title;
            richTextBox1.Text = Evnts.Description;
            startTimePicker1.Value = Evnts.StartDate;
            endTimePicker1.Value = Evnts.EndDate;
            lastTimePicker1.Value = Evnts.LastApplyingDate;

        }
        private void Editbutton1_Click(object sender, EventArgs e)
        {
            if (lastTimePicker1.Value.Date < startTimePicker1.Value.Date && startTimePicker1.Value.Date < endTimePicker1.Value.Date)
            {
                Evnts.Title = textBox6.Text;
                Evnts.Description = richTextBox1.Text;
                Evnts.StartDate = startTimePicker1.Value.Date;
                Evnts.EndDate = endTimePicker1.Value.Date;
                Evnts.LastApplyingDate = lastTimePicker1.Value.Date;
                Services.UpdateServices.UpdateEvent(Evnts);
                MessageBox.Show("Eventet har uppdaterats");
            }
            else MessageBox.Show("Kolla datumen");

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

    }
}
