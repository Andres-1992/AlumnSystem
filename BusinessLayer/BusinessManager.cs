using System;
using System.Collections.Generic;
using BusinessEntities;
using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;

namespace BusinessLayer
{
    public class BusinessManager
    {
 AlumniContext alumniContext = new AlumniContext();
        public BusinessManager()
        {
            alumniContext.Database.EnsureCreated();
        }
       
        
        public void AddAlumn(Alumn alumn)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            alumniContext.SaveChanges();
            unitOfWork.ar.Insert(alumn);
            unitOfWork.ar.Save();
        }
        
        public void AddEvent(Event events)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            alumniContext.SaveChanges();
            unitOfWork.er.Insert(events);
            unitOfWork.er.Save();
        }

        public void UpdateEmployee(Employee employee)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            unitOfWork.empr.Update(employee);
            unitOfWork.empr.Save();
        }

    }
}
