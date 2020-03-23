using BusinessEntities.Junction;
using BusinessEntities.Models;
using DataLayer.Contexts;
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
        public IEnumerable<AlumnEvent> GetAlumnEvent(Alumn alumn)
        {
            var result = (from x in _context.AlumnEvent
                          where x.Alumn == alumn
                          select x).ToList();
            return result;
        }

        public IEnumerable<Alumn> GetAttendedAlumn(Event @event)
        {
            return (from x in _context.AlumnEvent
                    where x.Event.EventId.Equals(@event.EventId)
                    select x.Alumn).ToList();
        }
    }
}
