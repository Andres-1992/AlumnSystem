using BusinessEntities;
using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class LogInService
    {
        AppDbContext appDbContext;
        UnitOfWork unitOfWork;
        public LogInService()
        {
            appDbContext = new AppDbContext();
            unitOfWork = new UnitOfWork(appDbContext);

        }
        public Employee LogInEmployee(string signature, string password)
        {
            return unitOfWork.Employees.LogIn(signature, password);
        }

        public Alumn LogInAlumn(string email, string password)
        {
            var result = unitOfWork.Alumns.LogIn(email, password);
            return result;
        }
        public void AddAlumn(Alumn alumn)
        {
            unitOfWork.Alumns.Insert(alumn);
            unitOfWork.Alumns.Save();
        }     
        
        public Alumn GetAlumn(int id)
        {
            return unitOfWork.Alumns.GetById(id);
        }

        public Employee GetEmployee(int id)
        {
            return unitOfWork.Employees.GetById(id);
        }
    }
}
