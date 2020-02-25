using BusinessEntities.Models;

namespace DataLayer
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Employee LogIn(string signature, string password);
    }
}