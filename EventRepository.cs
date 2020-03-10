using BusinessEntities;
using BusinessEntities.Models;
using DataLayer.Contexts;
using DataLayer.Contexts.Junction;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class EventRepository : GenericRepository<Event>, IEventRepository
    {
        AppDbContext _context;
        public EventRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Event> GetAttendedEvent(Alumn alumn)
        {
            return (from x in _context.AlumnEvent
                    where x.Alumn.AlumnId.Equals(alumn.AlumnId)
                    select x.Event).ToList();

        }

        public IEnumerable<Alumn> GetAttendedAlumn(Event events)
        {
            return (from x in _context.AlumnEvent
                    where x.Event.EventId.Equals(events.EventId)
                    select x.Alumn).ToList();

        }
        public IEnumerable<AlumnEvent> GetAlumnEvent(Alumn alumn)
        {
            var result = (from x in _context.AlumnEvent
                          where x.Alumn == alumn
                          select x).ToList();
            return result;
        }

    }
}
