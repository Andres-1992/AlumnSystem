using BusinessEntities.Models;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IEmployeeRepository:IGenericRepository<Employee>
    {
        Employee LogIn(string signature, string password);      
    }
}