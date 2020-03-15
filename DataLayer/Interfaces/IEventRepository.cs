using BusinessEntities;
using BusinessEntities.Junction;
using BusinessEntities.Models;

using System.Collections.Generic;

namespace DataLayer
{
    public interface IEventRepository : IGenericRepository<Event>
    {
        IEnumerable<Event> GetAttendedEvent(Alumn alumn);
         IEnumerable<AlumnEvent> GetAlumnEvent(Alumn alumn);
        IEnumerable<Alumn> GetAttendedAlumn(Event @event);
    }
}