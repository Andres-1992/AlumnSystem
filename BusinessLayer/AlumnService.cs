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
    public class AlumnService
    {
        AppDbContext appDbContext;
        UnitOfWork unitOfWork;
        public AlumnService()
        {
            appDbContext = new AppDbContext();
            unitOfWork = new UnitOfWork(appDbContext);
        }
        public void AddAlumnEvent(AlumnEvent ae)
        {
            appDbContext.AlumnEvent.Add(ae);
            appDbContext.SaveChanges();
        }
        public IEnumerable<Competence> GetCompetences(Alumn alumn)
        {
            return unitOfWork.Alumns.GetCompetences(alumn);
        }
        public void UpdateAlumn(Alumn alumn)
        {
            unitOfWork.Alumns.Update(alumn, alumn.AlumnId);
            unitOfWork.Alumns.Save();
        }

    }
}
