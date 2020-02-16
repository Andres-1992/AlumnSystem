﻿using BusinessEntities;
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
    public partial class UpdateAlumn : Form
    {
        Alumn alumn;
        BusinessManager businessManager;
        public UpdateAlumn()
        {
            InitializeComponent();
        }
        public UpdateAlumn(BusinessManager bm,Alumn a)
        {
            InitializeComponent();
            businessManager = bm;
            alumn = a;
            LoadInfo();
            this.Text = alumn.Name;
        }

        private void LoadInfo()
        {
            FirstNametextBox.Text = alumn.Name;
            EmailtextBox.Text = alumn.Email;
            PhoneNumbertextBox.Text = alumn.Phonenumber;
        }
        private void Cancelbutton_Click(object sender, EventArgs e)
        {

        }

        private void Applybutton_Click(object sender, EventArgs e)
        {
            string fullname = FirstNametextBox.Text + " " + SurNametextBox.Text;
            alumn.Name = fullname;
            alumn.Email = EmailtextBox.Text;
            alumn.Phonenumber = PhoneNumbertextBox.Text;
            businessManager.UpdateAlumn(alumn);
            MessageBox.Show("Dina uppgifter är uppdaterade");
        }
    }
}