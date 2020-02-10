using BusinessEntities.Contexts;
using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
  

    public partial class Form1 : Form
    {
        public List<Event> Events = new List<Event>();

        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string eventname = textBox1.Text;
            //string description = richTextBox1.Text;

            //Event eventet = new Event
            //{
            //    Title = eventname,
            //    Description = description

            //};
            //Events.Add(eventet);
            EventContext eventContext = new EventContext();
            eventContext.Database.EnsureDeleted();
            eventContext.Database.EnsureCreated();




        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
