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
        AppDbContext appDbContext;
        UnitOfWork unitOfWork;
        public BusinessManager()
        {
            appDbContext = AppDbContext.GetInstance();
            unitOfWork = new UnitOfWork(appDbContext);
            appDbContext.Database.EnsureCreated();
        }

        public static string Encrypt(string value)
        {
            using MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            byte[] data = md5.ComputeHash(utf8.GetBytes(value));
            return Convert.ToBase64String(data);
        }
   
        public IEnumerable<Event> GetEvent()
        {
             return unitOfWork.Events.GetAll();            
        }
    }
}
