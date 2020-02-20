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
        EmployeeService employeeService;
        public LoggedInEmployee()
        {
            InitializeComponent();
        }

        public LoggedInEmployee( Employee e)
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            employee = e;
        }

        private void CreateEventbutton1_Click(object sender, EventArgs e)
        {
            AddEvent addevent = new AddEvent(employeeService,employee);
            this.Hide();
            addevent.ShowDialog(this);
        }

        private void LogOutbutton1_Click(object sender, EventArgs e)
        {
            Owner.Show();   
        }

        private void AccountInfobutton1_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee(employeeService, employee);            
            this.Hide();
            updateEmployee.ShowDialog(this);

        }
    }
}
