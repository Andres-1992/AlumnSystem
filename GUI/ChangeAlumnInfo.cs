using BusinessEntities;
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
    public partial class ChangeAlumnInfo : Form
    {
        BusinessManager bm = new BusinessManager();
        public ChangeAlumnInfo()
        {
            InitializeComponent();
            alumn = bm.GetById(3);
            Loaded();
            this.Text = alumn.Name;
        }
        Alumn alumn;

        private void Loaded()
        {
            FirstNametextBox2.Text = alumn.Name;
            EmailtextBox2.Text = alumn.Email;
            PhoneNumbertextBox2.Text = alumn.Phonenumber;
        }
        private void Cancelbutton2_Click(object sender, EventArgs e)
        {
            LoggedInAlumn inloggadAlumn = new LoggedInAlumn();
            inloggadAlumn.Show();
            this.Hide();
        }

        private void Applybutton2_Click(object sender, EventArgs e)
        {

            string fullname = FirstNametextBox2.Text + " " + SurNametextBox2.Text;
            alumn.Name = fullname;
            alumn.Email = EmailtextBox2.Text;
            alumn.Phonenumber = PhoneNumbertextBox2.Text;
            

            bm.UpdateAlumn(alumn);
            MessageBox.Show("Dina uppgifter är uppdaterade");
        }
    }
}
