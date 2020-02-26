using BusinessEntities;
using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using DataLayer.Contexts.Junction;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class AlumnService : IAlumnService
    {
        AppDbContext AppDbContext;
        UnitOfWork UnitOfWork;

        public AlumnService(AppDbContext appDbContext, UnitOfWork unitOfWork)
        {
            AppDbContext = appDbContext;
            UnitOfWork = unitOfWork;
        }

        public void AddAlumnEvent(AlumnEvent alumnEvent)
        {
            AppDbContext.AlumnEvent.Add(alumnEvent);
            AppDbContext.SaveChanges();
        }

        public IEnumerable<Competence> GetCompetences(Alumn alumn)
        {
            return UnitOfWork.Alumns.GetCompetences(alumn);
        }

        public IEnumerable<Event> GetAttendedEvent(Alumn alumn)
        {
            return UnitOfWork.Events.GetAttendedEvent(alumn);
        }

        public void UpdateAlumn(Alumn alumn)
        {
            UnitOfWork.Alumns.Update(alumn);
            UnitOfWork.Alumns.Save();
        }

        public IEnumerable<AlumnEvent> GetAlumnEvent(Alumn alumn)
        {
            return UnitOfWork.Events.GetAlumnEvent(alumn);
        }

        public void DeleteAlumn(int id)
        {
            UnitOfWork.Alumns.Delete(id);
            UnitOfWork.Alumns.Save();
        }

        public void RemoveMyEvent(AlumnEvent alumnEvent)
        {
            AppDbContext.AlumnEvent.Remove(alumnEvent);
            AppDbContext.SaveChanges();
        }
    }
}
