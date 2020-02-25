using BusinessEntities;
using BusinessEntities.Enums;
using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class EmployeeService : IEmployeeService
    {
        AppDbContext AppDbContext;
        UnitOfWork UnitOfWork;

        public EmployeeService(AppDbContext appDbContext, UnitOfWork unitOfWork)
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

        public IEnumerable<Alumn> GetAlumnsByEducation(Education education)
        {
            return UnitOfWork.Alumns.GetAlumnsByEducation(education);
        }

        public IEnumerable<Alumn> GetAll()
        {
            return UnitOfWork.Alumns.GetAll();
        }
    }
}
