using BusinessEntities.Models;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DataLayer
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        AppDbContext _context;
        public EmployeeRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Campaign> GetCampaigns(Employee employee)
        {
            return (from x in _context.Campaigns
                    where x.Creator == employee
                    select x).ToList();
        }

        public Employee LogIn(string signature, string password)
        {
            return (from x in _context.Employees
                    where x.Signature == signature && x.Password == password
                    select x).FirstOrDefault();
        }
       
    }
}
