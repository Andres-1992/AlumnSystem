using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using DataLayer.Contexts;

namespace DataLayer
{
    public class UnitOfWork
    {

        private AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Alumns = new AlumnRepository(_context);
            Employees = new EmployeeRepository(_context);
            Events = new EventRepository(_context);
            Competences = new CompetenceRepository(_context);
        }
        public IAlumnRepository Alumns { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public IEventRepository Events { get; private set; }
        public ICompetenceRepository Competences { get; set; }

    }
    
}
