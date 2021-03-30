using BusinessEntities.Enums;
using BusinessEntities.Junction;
using BusinessEntities.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IGetCollectionService
    {
        IEnumerable<Event> GetEvents();
        IEnumerable<Alumn> GetAlumnsByEducation(Education education);
        IEnumerable<Alumn> GetAllAlumns();
        IEnumerable<Campaign> GetCampaigns(Employee employee);
        IEnumerable<Competence> GetCompetences(Alumn alumn);
        IEnumerable<Event> GetAttendedEvents(Alumn alumn);
        IEnumerable<AlumnEvent> GetAlumnEvents(Alumn alumn);
        IEnumerable<Alumn> GetAttendedAlumn(Event @event);
    }
}