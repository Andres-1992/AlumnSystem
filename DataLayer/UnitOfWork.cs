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
        }
        public IAlumnRepository Alumns { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public IEventRepository Events { get; private set; }


    }

}
