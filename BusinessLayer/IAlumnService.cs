using BusinessEntities;
using BusinessEntities.Enums;
using BusinessEntities.Models;
using DataLayer.Contexts.Junction;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IAlumnService
    {
        void AddAlumnEvent(AlumnEvent ae);
        IEnumerable<Alumn> GetAll();
        IEnumerable<Event> GetAttendedEvent(Alumn alumn);
        Alumn GetById(int id);
        IEnumerable<Competence> GetCompetences(Alumn alumn);
        void UpdateAlumn(Alumn alumn);
        IEnumerable<Alumn> GetAlumnsByEducation(Education education);
    }
}