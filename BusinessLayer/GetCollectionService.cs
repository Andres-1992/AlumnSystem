using BusinessEntities.Enums;
using BusinessEntities.Junction;
using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class GetCollectionService : IGetCollectionService
    {
        AppDbContext AppDbContext;
        UnitOfWork UnitOfWork;
        public GetCollectionService(AppDbContext appDbContext, UnitOfWork unitOfWork)
        {
            AppDbContext = appDbContext;
            UnitOfWork = unitOfWork;
        }
        public IEnumerable<Alumn> GetAllAlumns()
        {
            return UnitOfWork.Alumns.GetAll();
        }

        public IEnumerable<Alumn> GetAlumnsByEducation(Education education)
        {
            return UnitOfWork.Alumns.GetAlumnsByEducation(education);
        }

        public IEnumerable<Campaign> GetCampaigns(Employee employee)
        {
            return UnitOfWork.Employees.GetCampaigns(employee);
        }

        public IEnumerable<Event> GetEvents()
        {
            return UnitOfWork.Events.GetAll();
        }

        public IEnumerable<Competence> GetCompetences(Alumn alumn)
        {
            return UnitOfWork.Alumns.GetCompetences(alumn);
        }

        public IEnumerable<Event> GetAttendedEvents(Alumn alumn)
        {
            return UnitOfWork.Events.GetAttendedEvent(alumn);
        }

        public IEnumerable<AlumnEvent> GetAlumnEvents(Alumn alumn)
        {
            return UnitOfWork.Events.GetAlumnEvent(alumn);
        }

        public IEnumerable<Alumn> GetAttendedAlumn(Event @event)
        {
            return UnitOfWork.Events.GetAttendedAlumn(@event);
        }
    }
}
