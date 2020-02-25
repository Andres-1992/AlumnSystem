using BusinessEntities;
using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class LogInService : ILogInService
    {
        AppDbContext AppDbContext;
        UnitOfWork UnitOfWork;
        public LogInService(AppDbContext appDbContext,UnitOfWork unitOfWork)
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
            var result = UnitOfWork.Alumns.LogIn(email, password);
            return result;
        }
        public void AddAlumn(Alumn alumn)
        {
            UnitOfWork.Alumns.Insert(alumn);
            UnitOfWork.Alumns.Save();
        }
    }
}
