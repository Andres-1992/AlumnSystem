using BusinessEntities.Junction;
using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class AttendEvent : Form
    {
        Alumn Alumn { get; set; }
        Services Services { get; set; }

        public AttendEvent(Services services, Alumn alumn)
        {
            InitializeComponent();
            Alumn = alumn;
            Services = services;
            LoadDataGridView();

        }

        private void Applybutton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Event obj = (Event)dataGridView1.CurrentRow.DataBoundItem; ;
                if (!Services.GetCollectionServices.GetAttendedEvents(Alumn).Contains(obj))
                {
                    AlumnEvent alumnEvent = new AlumnEvent() { Alumn = Alumn, Event = obj };
                    Services.AddServices.AddAlumnEvent(alumnEvent);
                    MessageBox.Show("Du har registrerat dig på eventet: " + obj.Title);
                    LoadDataGridView();

                }
                else
                {
                    MessageBox.Show("Du har redan registrerat dig på eventet: " + obj.Title);
                }
            }
            else
            {
                MessageBox.Show("Inget event valt");
            }
        }

        private void HideColumns()
        {
            dataGridView1.Columns["AlumnEvents"].Visible = false;
            dataGridView1.Columns["Employee"].Visible = false;
            dataGridView1.Columns["EmployeeId"].Visible = false;
            dataGridView2.Columns["EmployeeId"].Visible = false;
            dataGridView2.Columns["AlumnEvents"].Visible = false;
            dataGridView2.Columns["Employee"].Visible = false;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count > 0)
            {
                Event evnt = (Event)dataGridView2.CurrentRow.DataBoundItem;
                var result = Services.GetCollectionServices.GetAlumnEvents(Alumn).Where(x => x.Event.Equals(evnt) && x.Alumn.Equals(Alumn)).FirstOrDefault();
                Services.DeleteServices.RemoveMyEvent(result);
                dataGridView2.DataSource = null;
                LoadDataGridView();
            }
            else
            {
                MessageBox.Show("Inget event valt");
            }
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }


        private void LoadDataGridView()
        {
            dataGridView1.DataSource = Services.GetCollectionServices.GetEvents();
            dataGridView2.DataSource = Services.GetCollectionServices.GetAttendedEvents(Alumn);
            HideColumns();
        }
    }
}
