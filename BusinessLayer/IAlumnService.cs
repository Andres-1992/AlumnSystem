using BusinessEntities;
using BusinessEntities.Models;
using DataLayer.Contexts.Junction;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IAlumnService
    {
        void AddAlumnEvent(AlumnEvent ae);
        IEnumerable<Event> GetAttendedEvent(Alumn alumn);
        IEnumerable<Competence> GetCompetences(Alumn alumn);
        void UpdateAlumn(Alumn alumn);
        void DeleteAlumn(int id);
        IEnumerable<AlumnEvent> GetAlumnEvent(Alumn alumn);
        void RemoveMyEvent(AlumnEvent alumnEvent);
        Alumn GetAlumn(int id);
    }
}