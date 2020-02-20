using BusinessEntities;
using BusinessEntities.Models;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IAlumnRepository:IGenericRepository<Alumn>
    {
        Alumn LogIn(string username, string password);
        IEnumerable<Competence> GetCompetences(Alumn alumn);
        IEnumerable<Event> GetAttendedEvent(Alumn alumn);
    }
}