using BusinessEntities;
using BusinessEntities.Enums;
using BusinessEntities.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IEmployeeService
    {
        void AddEvent(Event events);
        void UpdateEmployee(Employee employee);
        void UpdateEvent(Event events);
        IEnumerable<Alumn> GetAlumnsByEducation(Education education);
        IEnumerable<Alumn> GetAll();
    }
}