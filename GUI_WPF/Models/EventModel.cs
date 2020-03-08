using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using BusinessLayer;
using DataLayer.Contexts;
using DataLayer;
using System.Threading.Channels;
using Caliburn.Micro;
using BusinessEntities.Models;
using AutoMapper;

namespace GUI_WPF.Models
{
    public class EventModel : INotifyPropertyChanged
    {
        public EventModel()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Event, EventModel>();
            });
            mapper = config.CreateMapper();
        }
        private IMapper mapper;
        private int _eventId;
        private string _title;
        private string _description;
        private DateTime _startdate;
        private DateTime _enddate;
        private DateTime _lastapplyingdate;
        private EmployeeModel _creator;

        public event PropertyChangedEventHandler PropertyChanged;

        #region Properties
        public int EventId
        {
            get { return _eventId; }
            set { _eventId = value; Changed(); }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; Changed(); }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; Changed(); }
        }

        public DateTime StartDate
        {
            get { return _startdate; }
            set { _startdate = value; Changed(); }
        }

        public DateTime EndDate
        {
            get { return _enddate; }
            set { _enddate = value; Changed(); }
        }

        public DateTime LastApplyingDate
        {
            get { return _lastapplyingdate; }
            set { _lastapplyingdate = value; Changed(); }
        }

        public EmployeeModel Creator
        {
            get { return _creator; }
            set { _creator = value; Changed(); }
        }
        #endregion

        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Delete(Services services)
        {
            services.EmployeeServices.RemoveEvent(EventId);
        }


        public void SaveEvent(Services services)
        {
            Employee employee = services.EmployeeServices.GetEmployee(Creator.EmployeeId);
            Event newEvent = new Event(
                this.Title,
                this.Description,
                this.StartDate,
                this.EndDate,
                this.LastApplyingDate,
                employee);
            services.EmployeeServices.AddEvent(newEvent);
        }

        public void UpdateEvent(Services services)
        {
            Event @event = services.EmployeeServices.GetEventById(this.EventId);
            @event.Title = this.Title;
            @event.Description = this.Description;
            @event.StartDate = this.StartDate;
            @event.EndDate = this.EndDate;
            @event.LastApplyingDate = this.LastApplyingDate;

            services.EmployeeServices.UpdateEvent(@event);
        }

        public ObservableCollection<EventModel> GetEvents(Services services)
        {
            ObservableCollection<EventModel> x = new ObservableCollection<EventModel>();
            foreach (var item in services.BusinessManager.GetEvent())
            {
                EventModel eventModel = mapper.Map<Event, EventModel>(item);
                x.Add(eventModel);
            }
            return x;
        }
    }
}
