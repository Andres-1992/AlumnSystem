using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
   public class EmployeeService
    {
        AppDbContext appDbContext;
        UnitOfWork unitOfWork;
        public EmployeeService()
        {
            appDbContext = new AppDbContext();
            unitOfWork = new UnitOfWork(appDbContext);
        }
        public void AddEvent(Event events)
        {
            unitOfWork.Events.Insert(events);
            unitOfWork.Events.Save();
        } 
        
        public void UpdateEmployee(Employee employee)
        {
            unitOfWork.Employees.Update(employee, employee.EmployeeId);
            unitOfWork.Employees.Save();
        }
    }
}
