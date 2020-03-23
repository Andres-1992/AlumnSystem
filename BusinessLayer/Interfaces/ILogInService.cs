using BusinessEntities.Models;

namespace BusinessLayer
{
    public interface ILogInService
    {
        public string Encrypt(string value);
        Alumn LogInAlumn(string email, string password);
        Employee LogInEmployee(string signature, string password);
    }
}