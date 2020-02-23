using BusinessEntities;
using BusinessEntities.Enums;
using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class CreateCampaign : Form
    {
        Services Services { get; set; }
        SubscriberList SubscriberList;
        Campaign Campaign;
        public CreateCampaign(Services services)
        {

            InitializeComponent();
            Services = services;
            comboBox1.DataSource = Enum.GetValues(typeof(Education));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alumnCheckListBox.DataSource = Services.AlumnServices.GetAlumnsByEducation((Education)Enum.Parse(typeof(Education), comboBox1.SelectedValue.ToString()));
        }

        private void showAllBt_Click(object sender, EventArgs e)
        {
            alumnCheckListBox.DataSource = Services.AlumnServices.GetAll().Select(x => new { x.Name, x.Email, x.Education }).ToList();
        }
        List<Alumn> Alumns = new List<Alumn>();
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in alumnCheckListBox.CheckedItems.OfType<Alumn>())
            {
                if (!Alumns.Contains(item))
                {
                    Alumns.Add(item);
                }
            }

            listView1.Items.Clear();
            foreach (var item in Alumns)
            {
                var rad = new string[] { item.Name, item.Email };
                var listView = new ListViewItem(rad);
                listView1.Items.Add(listView);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubscriberList = new SubscriberList() { alumns = Alumns, Created = DateTime.Now };            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = SubscriberList;
            Campaign = new Campaign() { subscriberLists=new List<SubscriberList>(), Created=DateTime.Now,sent=true, Message=richTextBox1.Text };
            Campaign.subscriberLists.Add(SubscriberList);
            MessageBox.Show("Du har skapat en ny utskickslista");
        }
    }
}
