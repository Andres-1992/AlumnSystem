using BusinessEntities;

namespace DataLayer
{
    public interface IAlumnRepository:IGenericRepository<Alumn>
    {
        Alumn LogIn(string username, string password);
    }
}