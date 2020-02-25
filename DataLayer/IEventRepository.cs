using BusinessEntities;
using BusinessEntities.Models;
using DataLayer.Contexts.Junction;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IEventRepository : IGenericRepository<Event>
    {
        IEnumerable<Event> GetAttendedEvent(Alumn alumn);
        public IEnumerable<AlumnEvent> GetAlumnEvent(Alumn alumn);
    }
}