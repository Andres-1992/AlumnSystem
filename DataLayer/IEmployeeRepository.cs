using BusinessEntities.Models;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IEmployeeRepository:IGenericRepository<Employee>
    {
        IEnumerable<Employee> GetSpecificEmployee();
    }
}