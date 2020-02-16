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
    public partial class InloggadPersonal : Form
    {
        Employee employee;

        public InloggadPersonal()
        {
            InitializeComponent();
        }

        public InloggadPersonal(Employee e)
        {
            InitializeComponent();
            employee = e;
        }

        private void CreateEventbutton1_Click(object sender, EventArgs e)
        {
            AddEvent addevent = new AddEvent();
            addevent.Show();
            this.Hide();
        }

        private void LogOutbutton1_Click(object sender, EventArgs e)
        {
            LogIn form1 = new LogIn();
            form1.Show();
            this.Hide();           
            
        }

        private void AccountInfobutton1_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee();
            updateEmployee.Show();
            this.Hide();

        }
    }
}
