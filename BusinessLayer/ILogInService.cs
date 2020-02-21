using BusinessEntities;
using BusinessEntities.Models;

namespace BusinessLayer
{
    public interface ILogInService
    {
        void AddAlumn(Alumn alumn);
        Alumn GetAlumn(int id);
        Employee GetEmployee(int id);
        Alumn LogInAlumn(string email, string password);
        Employee LogInEmployee(string signature, string password);
    }
}