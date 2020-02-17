using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Contexts;
using System.Linq;

namespace DataLayer
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        AppDbContext _context;
        public EmployeeRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        /// <summary>
        /// Test Metod, glöm inte att ta bort onödig metod innan inlämning
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetSpecificEmployee()
        {
            var result = (from x in _context.Employees
                          where x.Signature == "JEHSA"
                          select x).ToList();
            return result;
        }
    }
}
