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

        UnitOfWork unitOfWork = new UnitOfWork();
        public void AddAlumn(Alumn alumn)
        {
            
            alumniContext.SaveChanges();
            unitOfWork.ar.Insert(alumn);
            unitOfWork.ar.Save();
        }
        
        public void AddEvent(Event events)
        {
            
            alumniContext.SaveChanges();
            unitOfWork.er.Insert(events);
            unitOfWork.er.Save();
        }

        public Alumn GetById(int id)
        {
            var qs = unitOfWork.ar.GetById(3);
            return qs;
        }
        public Employee GetById2(int id)
        {
            

         var qs=   unitOfWork.empr.GetById(4);
            return qs;
                
        }

        public void UpdateEmployee(Employee employee)
        {
           
            unitOfWork.empr.Update(employee, employee.EmployeeId);
            unitOfWork.empr.Save();
            alumniContext.SaveChanges();
        }

        public void UpdateAlumn(Alumn alumn)
        {
            unitOfWork.ar.Update(alumn, alumn.AlumnId);
            unitOfWork.ar.Save();
            alumniContext.SaveChanges();
        }

    }
}
