using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class EmployeeService : IEmployeeService
    {
        AppDbContext AppDbContext;
        UnitOfWork UnitOfWork;

        public EmployeeService(AppDbContext appDbContext,UnitOfWork unitOfWork) 
        {
            AppDbContext = appDbContext;
            UnitOfWork = unitOfWork;
        }
        public void AddEvent(Event events)
        {
            UnitOfWork.Events.Insert(events);
            UnitOfWork.Events.Save();
        }

        public void UpdateEmployee(Employee employee)
        {
            UnitOfWork.Employees.Update(employee);
            UnitOfWork.Employees.Save();
        }

        public void UpdateEvent(Event events)
        {
            UnitOfWork.Events.Update(events);
            UnitOfWork.Events.Save();
        }
    }
}
