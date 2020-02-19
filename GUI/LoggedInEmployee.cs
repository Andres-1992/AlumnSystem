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
    public partial class LoggedInEmployee : Form
    {
        Employee employee;
        BusinessManager businessmanager;
        public LoggedInEmployee()
        {
            InitializeComponent();
        }

        public LoggedInEmployee(BusinessManager bm, Employee e)
        {
            InitializeComponent();
            businessmanager = bm;
            employee = e;
        }

        private void CreateEventbutton1_Click(object sender, EventArgs e)
        {
            AddEvent addevent = new AddEvent(businessmanager,employee);
            this.Hide();
            addevent.ShowDialog(this);
        }

        private void LogOutbutton1_Click(object sender, EventArgs e)
        {
            Owner.Show();   
        }

        private void AccountInfobutton1_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee(businessmanager, employee);            
            this.Hide();
            updateEmployee.ShowDialog(this);

        }
    }
}
