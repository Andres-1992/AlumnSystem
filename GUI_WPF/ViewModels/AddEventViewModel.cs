using System;
using System.ComponentModel;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GUI_WPF.Models;
using System.Threading.Channels;
using System.Runtime.CompilerServices;
using System.Reflection;
using BusinessLayer;

namespace GUI_WPF.ViewModels
{
    public class AddEventViewModel : INotifyPropertyChanged
    {
        public AddEventViewModel()
        {
            Update();
        }


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

        public void DeleteEvent(object selectedItem)
        {
            ((Event)selectedItem).Delete();
            Update();
        }

        private Event events = new Event();

        public Event Event
        {
            get { return events; }
            set { events = value;
                Changed();
            }
        }
        private ObservableCollection<Event> eventslist;
        public ObservableCollection<Event> Eventslist
        {
            get { return eventslist; }
            set { eventslist = value;
                Changed();
            }
        }
        public void Update()
        {
            Eventslist = events.GetEvents();
        }
        

    }
}
