using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class UpdateEmployee : Form
    {
        Services Services { get; set; }
        Employee Employee { get; set; }
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        public UpdateEmployee(Services services, Employee employee)
        {
            InitializeComponent();
            Services = services;
            Employee = employee;
            this.Text = Employee.Name;
            LoadInfo();
        }

        private void LoadInfo()
        {
            var names = Employee.Name.Split(' ');
            FirstNametextBox.Text = names[0];
            for (int i = 1; i < names.Length; i++)
            {
                SurnametextBox.Text += names[i] + " ";
            }
            EmailtextBox.Text = Employee.Email;
            PhoneNumbertextBox.Text = Employee.Phonenumber;
        }
        private void Applybutton_Click(object sender, EventArgs e)
        {
            string fullname = FirstNametextBox.Text + " " + SurnametextBox.Text;
            Employee.Name = fullname;
            Employee.Email = EmailtextBox.Text;
            Employee.Phonenumber = PhoneNumbertextBox.Text;

            Services.UpdateServices.UpdateEmployee(Employee);
            MessageBox.Show("Dina uppgifter är uppdaterade");
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }
    }
}
