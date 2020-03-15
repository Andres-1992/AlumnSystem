using BusinessEntities;
using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using System;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer
{
    public class LogInService : ILogInService
    {
        AppDbContext AppDbContext;
        UnitOfWork UnitOfWork;
        public LogInService(AppDbContext appDbContext, UnitOfWork unitOfWork)
        {
            AppDbContext = appDbContext;
            UnitOfWork = unitOfWork;
        }

        public Employee LogInEmployee(string signature, string password)
        {
            return UnitOfWork.Employees.LogIn(signature, password);
        }

        public Alumn LogInAlumn(string email, string password)
        {
          return UnitOfWork.Alumns.LogIn(email, password);
           
        }

        public string Encrypt(string value)
        {
            using MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            byte[] data = md5.ComputeHash(utf8.GetBytes(value));
            return Convert.ToBase64String(data);
        }
    }
}
