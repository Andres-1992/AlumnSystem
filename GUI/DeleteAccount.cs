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

        private void button1_Click(object sender, EventArgs e)
        {

            if (BusinessManager.Encrypt(textBox1.Text) == Alumn.Password)
            {
                Services.AlumnServices.DeleteAlumn(Alumn.AlumnId);


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }
    }
}
