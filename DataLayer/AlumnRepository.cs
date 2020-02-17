using BusinessEntities;
using DataLayer.Contexts;
using System;
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

        public Alumn LogIn(string username, string password)
        {
            var result = (from u in _context.Alumns
                         where u.Email == username && u.Password == password
                         select u).FirstOrDefault();
            return result;
        }

    }
}
