﻿using System;
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
    public partial class UpdateEmployee : Form
    {
        BusinessManager businessmanager;
        Employee employee;
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        public UpdateEmployee(BusinessManager bm, Employee e)
        {
            InitializeComponent();
            businessmanager = bm;
            employee = e;
            this.Text = employee.Name;
            LoadInfo();
        }
        
        private void LoadInfo()
        {
            var names = employee.Name.Split(' ');
            FirstNametextBox.Text = names[0];
            for (int i = 1; i < names.Length; i++)
            {
                SurnametextBox.Text += names[i] + " ";
            }
            EmailtextBox.Text = employee.Email;
            PhoneNumbertextBox.Text = employee.Phonenumber;
        }
        private void Applybutton_Click(object sender, EventArgs e)
        {
            string fullname = FirstNametextBox.Text + " " + SurnametextBox.Text;
            employee.Name = fullname;
            employee.Email = EmailtextBox.Text;
            employee.Phonenumber = PhoneNumbertextBox.Text;

           businessmanager.UpdateEmployee(employee);
            MessageBox.Show("Dina uppgifter är uppdaterade");
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }       
    }
}
