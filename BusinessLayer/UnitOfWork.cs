using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using DataLayer.Contexts;

namespace BusinessLayer
{
    public class UnitOfWork
    {

        private AlumniContext _context;
        public UnitOfWork(AlumniContext context)
        {
            _context = context;
            Alumns = new AlumnRepository(_context);
            Employees = new EmployeeRepository(_context);
            Events = new EventRepository(_context);
        }
        public IAlumnRepository Alumns { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public IEventRepository Events { get; private set; }


    }
    
}
