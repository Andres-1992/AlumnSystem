using BusinessEntities;
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
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (BusinessManager.Encrypt(passwordTextBox.Text) == Alumn.Password)
            {
                Services.AlumnServices.DeleteAlumn(Alumn.AlumnId);
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

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }
    }
}
