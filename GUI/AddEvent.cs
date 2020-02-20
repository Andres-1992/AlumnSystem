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
        EmployeeService employeeService;
        Employee employee;
        public AddEvent()
        {
            InitializeComponent();

        }
        public AddEvent(EmployeeService eService, Employee e)
        {
            InitializeComponent();
            employeeService = eService;
            employee = e;
            availableForComboBox.DataSource = Enum.GetValues(typeof(Education));
        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            DateTime StartDate = StartDatePicker1.Value.Date;
            DateTime EndDate = EndDatePicker.Value.Date;
            DateTime LastApplyingDate = LastTimePicker.Value.Date;
            if (LastApplyingDate < StartDate && StartDate<EndDate)
            {
                Event events = new Event(EventTitletextBox.Text, DescriptionTextBox.Text, StartDate, EndDate, LastApplyingDate, employee.EmployeeId);
                employeeService.AddEvent(events);
                MessageBox.Show("Event tillagd");
                Owner.Show();
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }
    }

}
