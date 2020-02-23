using BusinessEntities;
using BusinessEntities.Enums;
using BusinessEntities.Models;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IAlumnRepository:IGenericRepository<Alumn>
    {
        Alumn LogIn(string username, string password);
        IEnumerable<Competence> GetCompetences(Alumn alumn);
        IEnumerable<Event> GetAttendedEvent(Alumn alumn);
        IEnumerable<Alumn> GetAlumnsByEducation(Education education);
    }
}