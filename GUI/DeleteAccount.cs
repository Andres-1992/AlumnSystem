using BusinessEntities;
using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class DeleteAccount : Form
    {
        Services Services;
        Alumn Alumn;
        public DeleteAccount(Services services, Alumn alumn)
        {
            InitializeComponent();
            Services = services;
            Alumn = alumn;
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Services.BusinessManager.Encrypt(passwordTextBox.Text) == Alumn.Password)
            {
                Services.AlumnServices.DeleteAlumn(Alumn.AlumnId);
                DeleteButton.DialogResult = DialogResult.Yes;
            }
            else
            {
                MessageBox.Show("Fel lösenord");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

    }
}
