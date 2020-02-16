using BusinessEntities.Models;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace DataLayer
{
    public class EventRepository : GenericRepository<Event>, IEventRepository
    {
        AlumniContext _context;
        public EventRepository(AlumniContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Test Metod, glöm inte att ta bort onödig metod innan inlämning
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Event> GetEvents()
        {
            var result = (from x in _context.Events
                          where x.Title == "JJ"
                          select x).ToList();
            return result;
        }
    }
}
