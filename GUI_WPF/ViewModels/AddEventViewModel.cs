
using GUI_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace GUI_WPF.ViewModels
{
  public class AddEventViewModel :INotifyPropertyChanged
    {
        public AddEventViewModel()
        {
            Update();
        }

        private Event _selectedEvent;
        private Event events = new Event();
        private ObservableCollection<Event> _eventslist;

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddEvent()
        {
            Event events = new Event()
            {
                Title = Event.Title,
                Description = Event.Description,
                StartDate = Event.StartDate,
                EndDate = Event.EndDate,
                LastApplyingDate = Event.LastApplyingDate,
                EmployeeId = 1
            };
            events.SaveEvent();
            Update();
        }

        public Event SelectedEvent
        {
            get { return _selectedEvent; }
            set { _selectedEvent = value; Changed(); }
        }

        public void DeleteEvent()
        {
            ((Event)this.SelectedEvent).Delete();
            Update();
        }

        public Event Event
        {
            get { return events; }
            set
            {
                events = value;
                Changed();
            }
        }

        public ObservableCollection<Event> Eventslist
        {
            get { return _eventslist; }
            set
            {
                _eventslist = value;
                Changed();
            }
        }

        public void Update()
        {
            Eventslist = events.GetEvents();
        }        
    }

}
