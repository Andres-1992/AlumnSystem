using BusinessEntities;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class AlumnRepository : GenericRepository<Alumn>, IAlumnRepository
    {

        AlumniContext _context;
        public AlumnRepository(AlumniContext context)
        {
            _context = context;
        }

        public Alumn LogIn(string username, string password)
        {
            var result = (from u in _context.Alumns
                         where u.Email == username && u.Password == password
                         select u).FirstOrDefault();
            return result;
        }

    }
}
