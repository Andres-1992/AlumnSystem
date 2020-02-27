using BusinessEntities;
using BusinessEntities.Enums;
using BusinessEntities.Models;
using DataLayer.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class AlumnRepository : GenericRepository<Alumn>, IAlumnRepository
    {
        AppDbContext _context;
        public AlumnRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Alumn> GetAlumnsByEducation(Education education)
        {
            return (from x in _context.Alumns
                    where x.Education == education
                    select x).ToList();
        }


        public IEnumerable<Competence> GetCompetences(Alumn alumn)
        {
            return (from x in _context.Competence
                    where x.Alumn.AlumnId.Equals(alumn.AlumnId)
                    orderby x.CompetenceLevel descending
                    select x).ToList();
        }

        public Alumn LogIn(string username, string password)
        {
            return (from x in _context.Alumns
                    where x.Email == username && x.Password == password
                    select x).FirstOrDefault();

        }

    }
}
