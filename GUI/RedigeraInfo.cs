using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class RedigeraInfo : Form
    {
        public RedigeraInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
         
                label2.Text = "Old Email";
                label3.Text = "New Email";
                checkBox2.Hide();
                checkBox3.Hide();
                
            }
            else
            {
                label2.Text = "";
                label3.Text = "";
                textBox1.Clear();
                textBox2.Clear();
                checkBox2.Show();
                checkBox3.Show();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.PasswordChar = '*';
                textBox1.MaxLength = 20;
                textBox2.PasswordChar = '*';
                textBox2.MaxLength = 20;
                label2.Text = "Old Password";
                label3.Text = "New Password";
                checkBox1.Hide();
                checkBox3.Hide();

            }
            else
            {
                textBox1.PasswordChar = '\0';
                textBox2.PasswordChar = '\0';
                label2.Text = "";
                label3.Text = "";
                textBox1.Clear();
                textBox2.Clear();
                checkBox1.Show();
                checkBox3.Show();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
           
                label2.Text = "Old Phonenumber";
                label3.Text = "New Phonenumber";
                checkBox1.Hide();
                checkBox2.Hide();

            }
            else
            { 
                label2.Text = "";
                label3.Text = "";
                textBox1.Clear();
                textBox2.Clear();
                checkBox1.Show();
                checkBox2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes updated");
        }

        private void RedigeraInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
