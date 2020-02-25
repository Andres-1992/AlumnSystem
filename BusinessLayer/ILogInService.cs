using BusinessEntities;
using BusinessEntities.Models;

namespace BusinessLayer
{
    public interface ILogInService
    {
        void AddAlumn(Alumn alumn);
        Alumn LogInAlumn(string email, string password);
        Employee LogInEmployee(string signature, string password);
    }
}