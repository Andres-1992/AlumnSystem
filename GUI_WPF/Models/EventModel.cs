﻿using AutoMapper;
using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GUI_WPF.Models
{
    public class EventModel : INotifyPropertyChanged
    {
        public EventModel()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Event, EventModel>();
                cfg.CreateMap<Alumn, AlumnModel>();
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
        private Employee _creator;

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

        public Employee Creator
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
            services.DeleteServices.DeleteEvent(EventId);
        }

        public void SaveEvent(Services services)
        {
            Event newEvent = new Event(
                this.Title,
                this.Description,
                this.StartDate,
                this.EndDate,
                this.LastApplyingDate,
                Creator);

            services.AddServices.AddEvent(newEvent);
        }

        internal ObservableCollection<AlumnModel> GetAttendedAlumns(Services services)
        {
            ObservableCollection<AlumnModel> x = new ObservableCollection<AlumnModel>();
            Event @event = services.GetServices.GetEvent(EventId);
            foreach (var item in services.GetCollectionServices.GetAttendedAlumn(@event))
            {
                AlumnModel z = mapper.Map<Alumn, AlumnModel>(item);
                x.Add(z);
            }
            return x;
        }

        public void UpdateEvent(Services services)
        {
            Event @event = services.GetServices.GetEvent(this.EventId);
            @event.Title = this.Title;
            @event.Description = this.Description;
            @event.StartDate = this.StartDate;
            @event.EndDate = this.EndDate;
            @event.LastApplyingDate = this.LastApplyingDate;

            services.UpdateServices.UpdateEvent(@event);
        }

        public ObservableCollection<EventModel> GetEvents(Services services)
        {
            ObservableCollection<EventModel> x = new ObservableCollection<EventModel>();
            foreach (var item in services.GetCollectionServices.GetEvents())
            {
                EventModel eventModel = mapper.Map<Event, EventModel>(item);
                x.Add(eventModel);
            }
            return x;
        }

    }
}
