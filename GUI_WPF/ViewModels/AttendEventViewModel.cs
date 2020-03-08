using BusinessLayer;
using GUI_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace GUI_WPF.ViewModels
{
    public class AttendEventViewModel:INotifyPropertyChanged
    {
        AlumnModel AlumnModel { get; set; }
        Services Services { get; set; }
        public AttendEventViewModel(Services services, AlumnModel alumnModel)
        {
            AlumnModel = alumnModel;
            Services = services;
            LoadEvents();
        }

        private EventModel _eventModel = new EventModel();
        private ObservableCollection<EventModel> _availableEvents;
        private EventModel _selectedEvent;
        private ObservableCollection<EventModel> _attendedEvents;
        #region properties
        private EventModel _selectedToRemove;

        public EventModel SelectedToRemove
        {
            get { return _selectedToRemove; }
            set { _selectedToRemove = value; Changed(); }
        }


        public ObservableCollection<EventModel> AttendedEvents
        {
            get { return _attendedEvents; }
            set { _attendedEvents = value; Changed(); }
        }
        
        public EventModel SelectedEvent
        {
            get { return _selectedEvent; }
            set { _selectedEvent = value; Changed(); }
        }
        
        public EventModel EventModel
        {
            get { return _eventModel; }
            set { _eventModel = value; Changed(); }
        }

        public ObservableCollection<EventModel> AvailableEvents
        {
            get { return _availableEvents; }
            set { _availableEvents = value; Changed(); }
        }
        #endregion

        private void LoadEvents()
        {
            AvailableEvents = EventModel.GetEvents(Services);
            AttendedEvents = AlumnModel.GetAttendedEvents(Services);
        }
        public event PropertyChangedEventHandler PropertyChanged;
       
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        public void Attend()
        {
            AlumnModel.AttendEvent(Services,SelectedEvent.EventId);
            LoadEvents();
        }        
        public void Delete()
        {
            AlumnModel.RemoveEvent(Services,SelectedToRemove.EventId);
            LoadEvents();
        }
    }
}
