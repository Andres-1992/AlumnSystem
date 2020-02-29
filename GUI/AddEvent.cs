using BusinessEntities.Models;
using BusinessEntities.ObserverPattern;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace GUI
{
    public partial class AddEvent : Form, ISubject
    {
        Services Services { get; set; }
        Employee Employee { get; set; }
        List<IObserver> Observers { get; set; }
        public int Counter { get; set; }

        public void Register(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnRegister(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in Observers)
            {
                item.Update(this);
            }
        }

        private void UpdateCounter()
        {
            Counter = dataGridView1.RowCount;
            Notify();
        }
        public AddEvent(Services services, Employee employee)
        {
            InitializeComponent();
            Services = services;
            Employee = employee;
            Observers = new List<IObserver>();
            dataGridView1.DataSource = services.BusinessManager.GetEvent();
            HideColumns();
        }

        private void HideColumns()
        {
            dataGridView1.Columns["AlumnEvents"].Visible = false;
            dataGridView1.Columns["Employee"].Visible = false;
        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            if (ValidateTextBoxes())
            {
                DateTime StartDate = StartDatePicker1.Value.Date;
                DateTime EndDate = EndDatePicker.Value.Date;
                DateTime LastApplyingDate = LastTimePicker.Value.Date;
                if (LastApplyingDate < StartDate && StartDate < EndDate)
                {
                    Event events = new Event(EventTitletextBox.Text, DescriptionTextBox.Text, StartDate, EndDate, LastApplyingDate, Employee);
                    Services.EmployeeServices.AddEvent(events);
                    MessageBox.Show("Event tillagd");
                    dataGridView1.DataSource = Services.BusinessManager.GetEvent();
                    UpdateCounter();
                }
                else
                {
                    MessageBox.Show("Kolla datumen");
                }
            }
            else
            {
                MessageBox.Show("Alla fält är inte ifyllda");
            }

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void Editbutton1_Click(object sender, EventArgs e)
        {
            Event obj = (Event)dataGridView1.CurrentRow.DataBoundItem;
            EditEvent editevent = new EditEvent(Services, obj);
            this.Hide();
            editevent.ShowDialog(this);
        }

        private void DeleteButton1_Click(object sender, EventArgs e)
        {
            Event obj = (Event)dataGridView1.CurrentRow.DataBoundItem;
            Services.EmployeeServices.RemoveEvent(obj.EventId);
            MessageBox.Show($"Du har tagit bort {obj.Title} som skulle varit {obj.StartDate}");
            dataGridView1.DataSource = Services.BusinessManager.GetEvent();
            UpdateCounter();

        }
        private bool ValidateTextBoxes()
        {
            try
            {
                string textBoxData = string.Empty;

                foreach (Control item in this.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {

                        if (string.IsNullOrEmpty(item.Text))
                        {
                            return false;
                        }
                        textBoxData += item.Text;
                    }
                }
                return (textBoxData != string.Empty);
            }
            catch { return false; }

        }
    }
}
