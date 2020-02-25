using BusinessEntities.Models;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BusinessEntities;

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
    }
}
