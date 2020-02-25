using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer
{
    public class BusinessManager : IBusinessManager
    {
        AppDbContext AppDbContext;
        UnitOfWork UnitOfWork;
        public BusinessManager(AppDbContext appDbContext, UnitOfWork unitOfWork)
        {
            AppDbContext = appDbContext;
            UnitOfWork = unitOfWork;
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
            return UnitOfWork.Events.GetAll();
        }
    }
}
