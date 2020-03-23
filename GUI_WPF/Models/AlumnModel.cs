using AutoMapper;
using BusinessEntities.Enums;
using BusinessEntities.Junction;
using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
        #region Properties
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

        public ObservableCollection<Competence> Competences { get; internal set; }

        #endregion

        internal ObservableCollection<Competence> GetCompetences(Services services)
        {
            Alumn alumn = GetAlumn(services);
            ObservableCollection<Competence> x = new ObservableCollection<Competence>();
            foreach (var item in services.GetCollectionServices.GetCompetences(alumn))
            {
                x.Add(item);
            }
            return x;
        }

        internal AlumnModel GetLoggedInAlumn(string idInput, string password, Services services)
        {
            Alumn a = services.LogInServices.LogInAlumn(idInput, services.LogInServices.Encrypt(password));

            if (a != null)
            {
                AlumnModel x = mapper.Map<Alumn, AlumnModel>(a);
                return x;
            }
            else return null;
        }

        internal ObservableCollection<EventModel> GetAttendedEvents(Services services)
        {
            Alumn alumn = GetAlumn(services);
            IEnumerable<Event> attendedEvents = services.GetCollectionServices.GetAttendedEvents(alumn);

            ObservableCollection<EventModel> x = new ObservableCollection<EventModel>();

            foreach (var item in attendedEvents)
            {
                EventModel eventModel = mapper.Map<Event, EventModel>(item);
                x.Add(eventModel);
            }

            return x;
        }

        internal void RemoveEvent(Services services, int id)
        {
            Alumn a = GetAlumn(services);
            Event e = services.GetServices.GetEvent(id);
            AlumnEvent alumnEvent = services.GetCollectionServices.GetAlumnEvents(a).Where(x => x.Event.Equals(e) && x.Alumn.Equals(a)).FirstOrDefault();
            services.DeleteServices.RemoveMyEvent(alumnEvent);
        }

        internal void UpdateAlumn(Services services)
        {
            Alumn alumn = GetAlumn(services);
            alumn.Name = Name;
            alumn.Email = Email;
            alumn.Phonenumber = Phonenumber;
            alumn.Password = Password;
            alumn.Competences = Competences;
            services.UpdateServices.UpdateAlumn(alumn);
        }

        internal ObservableCollection<AlumnModel> GetAllAlumns(Services services)
        {
            ObservableCollection<AlumnModel> x = new ObservableCollection<AlumnModel>();
            foreach (var item in services.GetCollectionServices.GetAllAlumns())
            {
                AlumnModel alumns = mapper.Map<Alumn, AlumnModel>(item);
                x.Add(alumns);
            }
            return x;
        }

        internal ObservableCollection<AlumnModel> GetByAlumnsEducation(Education selectedEducation, Services services)
        {
            ObservableCollection<AlumnModel> x = new ObservableCollection<AlumnModel>();
            foreach (var item in services.GetCollectionServices.GetAlumnsByEducation(selectedEducation))
            {
                AlumnModel alumns = mapper.Map<Alumn, AlumnModel>(item);
                x.Add(alumns);
            }
            return x;
        }

        internal void AttendEvent(Services services, int id)
        {
            Alumn alumn = GetAlumn(services);
            Event @event = services.GetServices.GetEvent(id);
            if (!services.GetCollectionServices.GetAttendedEvents(alumn).Contains(@event))
            {
                AlumnEvent alumnEvent = new AlumnEvent() { Alumn = alumn, Event = @event };
                services.AddServices.AddAlumnEvent(alumnEvent);
                MessageBox.Show("Du har registrerat dig på eventet: " + @event.Title);
            }
        }

        internal Alumn GetAlumn(Services services)
        {
            return services.GetServices.GetAlumn(AlumnId);
        }

        internal void SaveAlumn(Services services)
        {
            Alumn alumn = mapper.Map<AlumnModel, Alumn>(this);
            services.AddServices.AddAlumn(alumn);
        }
    }
}
