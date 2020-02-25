using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Contexts;
using System.Linq;
using System.Security.Cryptography;

namespace DataLayer
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        AppDbContext _context;
        public EmployeeRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public Employee LogIn(string signature, string password)
        {
            return (from x in _context.Employees
                    where x.Signature == signature && x.Password == password
                    select x).FirstOrDefault();
        }
        //#region budget metoder glöm inte ta bort innan johannes ser
        //public void Seed()
        //{
        //    Employee emp = new Employee("Johannes Sahlin", "0722222222", "johannes.sahlin@hb.se", Encrypt("password"), "JHSA");
        //    Insert(emp);
        //    Employee emp1 = new Employee("Gideon Mbiydzenyuy", "0722222222", "gideon.mbiydzenyuy@hb.se", Encrypt("password"), "GIMB");
        //    Insert(emp1);
        //    Employee emp2 = new Employee("Anders Gidenstam", "0722222222", "anders.gidenstam@hb.se", Encrypt("password"), "AGD");
        //    Insert(emp2);
        //    Employee emp3 = new Employee("Anna Palquist", "0722222222", "anna.palmquist@hb.se", Encrypt("password"), "ANP");
        //    Insert(emp3);
        //    Employee emp4 = new Employee("Bim Fagerström Kareld", "0722222222", "bim.fagerstrom_kareld@hb.se", Encrypt("password"), "BIFA");
        //    Insert(emp4);
        //    Save();
        //}
        //public static string Encrypt(string value)
        //{
        //    using MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        //    UTF8Encoding utf8 = new UTF8Encoding();
        //    byte[] data = md5.ComputeHash(utf8.GetBytes(value));
        //    return Convert.ToBase64String(data);
        //}
        //#endregion
    }
}
