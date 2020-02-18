using BusinessEntities.Models;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataLayer
{
   public class CompetenceRepository : GenericRepository<Competence>, ICompetenceRepository
    {
        AppDbContext _context;
        public CompetenceRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<Competence> GetHighCompetences()
        {
            var result = (from x in _context.Competence
                          where x.Description.Contains("c#")
                          select x).ToList();
            return result;

        }
    }
}
