using AutoMapper;
using BusinessEntities.Enums;
using BusinessEntities.Junction;
using BusinessEntities.Models;
using BusinessLayer;
using DataLayer;
using DataLayer.Contexts;
using DataLayer.Contexts.Junction;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace GUI_WPF.Models
{
    public class AlumnModel : Person
    {

        public AlumnModel()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Alumn, AlumnModel>();
                cfg.CreateMap<AlumnModel, Alumn>();
                cfg.CreateMap<Event, EventModel>();
            });
            mapper = config.CreateMapper();

        }

        IMapper mapper { get; set; }
        private int _alumnId;
        private Education _education;
        private bool _work;
        #region properties

        public bool Work
        {
            get { return _work; }
            set { _work = value; }
        }

        public Education Education
        {
            get { return _education; }
            set { _education = value; }
        }

        public int AlumnId
        {
            get { return _alumnId; }
            set { _alumnId = value; }
        }
        #endregion
        #region GetMetoder
        internal ObservableCollection<Competence> GetCompetences(Services services)
        {
            Alumn alumn = services.AlumnServices.GetAlumn(AlumnId);
            ObservableCollection<Competence> x = new ObservableCollection<Competence>();
            foreach (var item in services.AlumnServices.GetCompetences(alumn))
            {
                x.Add(item);
            }

            return x;
        }
        internal AlumnModel GetLoggedInAlumn(string idInput, string password, Services services)
        {
            Alumn a = services.LogInServices.LogInAlumn(idInput, services.BusinessManager.Encrypt(password));

            if (a != null)
            {
                AlumnModel x = mapper.Map<Alumn, AlumnModel>(a);
                return x;
            }
            else return null;
        }

        internal ObservableCollection<EventModel> GetAttendedEvents(Services services)
        {
            Alumn alumn = services.AlumnServices.GetAlumn(AlumnId);
           var result = services.AlumnServices.GetAttendedEvent(alumn);
            ObservableCollection<EventModel> x = new ObservableCollection<EventModel>();
            foreach (var item in result)
            {
                 EventModel eventModel = mapper.Map<Event, EventModel>(item);
                x.Add(eventModel);
            }
            
            return x;
        }
        #endregion
        internal void RemoveEvent(Services services, int id)
        {
            Alumn a = services.AlumnServices.GetAlumn(AlumnId);
            Event e = services.EmployeeServices.GetEventById(id);
            var result = services.AlumnServices.GetAlumnEvent(a).Where(x => x.Event.Equals(e) && x.Alumn.Equals(a)).FirstOrDefault();
            services.AlumnServices.RemoveMyEvent(result);
        }

        internal void UpdateAlumn(Services services, ObservableCollection<Competence> c)
        {
            Alumn alumn = services.AlumnServices.GetAlumn(AlumnId);
            alumn.Name = Name;
            alumn.Email = Email;
            alumn.Phonenumber = Phonenumber;
            alumn.Password = Password;
            alumn.Competences = c;
            services.AlumnServices.UpdateAlumn(alumn);
        }

        internal void AttendEvent(Services services, int id)
        {
            Alumn a = services.AlumnServices.GetAlumn(AlumnId);
            Event e = services.EmployeeServices.GetEventById(id);
            if (!services.AlumnServices.GetAttendedEvent(a).Contains(e))
            {
                AlumnEvent alumnEvent = new AlumnEvent() { Alumn = a, Event = e };
                services.AlumnServices.AddAlumnEvent(alumnEvent);
                MessageBox.Show("Du har registrerat dig på eventet: " + e.Title);
            }
        }
    }
}
