using BusinessEntities;
using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using DataLayer.Contexts.Junction;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class AlumnService : IAlumnService
    {
        AppDbContext AppDbContext;
        UnitOfWork UnitOfWork;
        public AlumnService(AppDbContext appDbContext,UnitOfWork unitOfWork)
        {
            AppDbContext = appDbContext;
            UnitOfWork = unitOfWork ;

        }
        public void AddAlumnEvent(AlumnEvent ae)
        {
            AppDbContext.AlumnEvent.Add(ae);
            AppDbContext.SaveChanges();
        }
        public IEnumerable<Competence> GetCompetences(Alumn alumn)
        {
            return UnitOfWork.Alumns.GetCompetences(alumn);
        }

        public IEnumerable<Event> GetAttendedEvent(Alumn alumn)
        {
            return UnitOfWork.Alumns.GetAttendedEvent(alumn);
        }
        public void UpdateAlumn(Alumn alumn)
        {
            UnitOfWork.Alumns.Update(alumn);
            UnitOfWork.Alumns.Save();
        }
        public IEnumerable<Alumn> GetAll()
        {
            return UnitOfWork.Alumns.GetAll();
        }
        public Alumn GetById(int id)
        {
            return UnitOfWork.Alumns.GetById(id);
        }
    }
}
