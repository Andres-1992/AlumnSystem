using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using BusinessEntities;
using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;

namespace BusinessLayer
{
    public class BusinessManager
    {
 AlumniContext alumniContext = new AlumniContext();
        public BusinessManager()
        {
            alumniContext.Database.EnsureCreated();
        }
       
        
        public void AddAlumn(Alumn alumn)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
          
            unitOfWork.ar.Insert(alumn);
            unitOfWork.ar.Save();
        }
        
        public void AddEvent(Event events)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            
            unitOfWork.er.Insert(events);
            unitOfWork.er.Save();
        }
        public static string Encrypt(string value)
        {
            using MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            byte[] data = md5.ComputeHash(utf8.GetBytes(value));
            return Convert.ToBase64String(data);
        }
        public Alumn LogIn(string email,string password)
        {
            UnitOfWork unitOfWork = new UnitOfWork(); 
            var result = unitOfWork.ar.Login(email,password);
            return result;
        }

    }
}
