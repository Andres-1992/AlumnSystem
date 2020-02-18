using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using BusinessEntities;
using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using DataLayer.Contexts.Junction;

namespace BusinessLayer
{
    public class BusinessManager
    {
        AppDbContext alumniContext;
        UnitOfWork unitOfWork;

        public BusinessManager()
        {
            alumniContext = new AppDbContext();
            unitOfWork = new UnitOfWork(alumniContext);
            alumniContext.Database.EnsureCreated();
        }
        public void AddAE(AlumnEvent ae)
        {
            alumniContext.AlumnEvent.Add(ae);
            alumniContext.SaveChanges();
        }
        public void AddCompetence(Competence c)
        {
            unitOfWork.Competences.Insert(c);
            unitOfWork.Competences.Save();
        }

        public void AddAlumn(Alumn alumn)
        {
            unitOfWork.Alumns.Insert(alumn);
            unitOfWork.Alumns.Save();
        }

        public void AddEvent(Event events)
        {
            unitOfWork.Events.Insert(events);
            unitOfWork.Events.Save();
        }

        public static string Encrypt(string value)
        {
            using MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            byte[] data = md5.ComputeHash(utf8.GetBytes(value));
            return Convert.ToBase64String(data);
        }

        public Alumn LogInAlumn(string email, string password)
        {
            var result = unitOfWork.Alumns.LogIn(email, password);
            return result;
        }

        public Alumn GetAlumn(int id)
        {
            return unitOfWork.Alumns.GetById(id);
        }

        public Employee GetEmployee(int id)
        {
            return unitOfWork.Employees.GetById(id);
        }
        
        public IEnumerable<Event> GetEvent()
        {
            return unitOfWork.Events.GetAll();
        }

        public void UpdateEmployee(Employee employee)
        {
            unitOfWork.Employees.Update(employee, employee.EmployeeId);
            unitOfWork.Employees.Save();
        }

        public void UpdateAlumn(Alumn alumn)
        {
            unitOfWork.Alumns.Update(alumn, alumn.AlumnId);
            unitOfWork.Alumns.Save();
        }

    }
}
