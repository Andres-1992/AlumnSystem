using System;
using BusinessEntities.Models;
using BusinessLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class ÄndraPersonalUppgifter : Form
    {
        BusinessManager bm = new BusinessManager();
        public ÄndraPersonalUppgifter()
        {
            InitializeComponent();
            employee = bm.GetById(4);
           
               

        }
        Employee employee;
        private void Applybutton1_Click(object sender, EventArgs e)
        {


            string fullname = FirstNametextBox1.Text + " " + SurnametextBox1.Text;
            employee.Name = fullname;
            employee.Email = EmailtextBox1.Text;
            employee.Phonenumber = PhoneNumbertextBox1.Text;

            bm.UpdateEmployee(employee);
            MessageBox.Show("Dina uppgifter är uppdaterade");
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            InloggadPersonal inloggadpersonal = new InloggadPersonal();
            inloggadpersonal.Show();
            this.Hide();
        }

        private void FirstNametextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SurnametextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNumbertextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailtextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
