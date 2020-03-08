
using BusinessEntities.Models;
using BusinessLayer;
using Caliburn.Micro;
using DataLayer;
using DataLayer.Contexts;
using GUI_WPF.Models;
using GUI_WPF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace GUI_WPF.ViewModels
{
  public class AddEventViewModel :INotifyPropertyChanged
    {

        Services Services { get; set; }

 
        public AddEventViewModel(Services services, EmployeeModel employeeModel)
        {
            Services = services;
            Creator= employeeModel;
            Update();
        }

        private EventModel _selectedEvent;
        private EventModel _event = new EventModel();
        private ObservableCollection<EventModel> _eventList;
        public event PropertyChangedEventHandler PropertyChanged;
        private EmployeeModel _creator;

        public EmployeeModel Creator
        {
            get { return _creator; }
            set { _creator = value; }
        }


        public EventModel SelectedEvent
        {
            get { return _selectedEvent; }
            set 
            {
                _selectedEvent = value;
                Changed();
            }
        }

        public EventModel EventModel
        {
            get { return _event; }
            set
            {
                _event = value;
                Changed();
            }
        }

        public ObservableCollection<EventModel> EventList
        {
            get { return _eventList; }
            set
            {
                _eventList = value;
                Changed();
            }
        }

        #region Button/metoder
        public void AddEvent()
        {
           // Employee employee = Services.EmployeeServices.GetEmployee(Creator.EmployeeId);
            EventModel events = new EventModel()
            {
                Title = EventModel.Title,
                Description = EventModel.Description,
                StartDate = EventModel.StartDate,
                EndDate = EventModel.EndDate,
                LastApplyingDate = EventModel.LastApplyingDate,
                Creator = Creator
              };
            events.SaveEvent(Services);
            Update();
        }

        public void Update()
        {
           
            EventList = EventModel.GetEvents(Services);
            
        }
        
        public void EditEvent()
        {
           SelectedEvent.UpdateEvent(Services);
           MessageBox.Show("Eventet: "+SelectedEvent.Title+" har uppdaterats");
           Update();
            
        } 
        
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        public void DeleteEvent()
        {
           this.SelectedEvent.Delete(Services);
            Update();
        }
        #endregion

    }

}
