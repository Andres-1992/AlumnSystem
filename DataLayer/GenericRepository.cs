﻿using BusinessEntities;
using DataLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
       
        private AlumniContext _context = null;
        private DbSet<T> table = null;

        public GenericRepository()
        {
            this._context = new AlumniContext();
            table = _context.Set<T>();
        }
        public GenericRepository(AlumniContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(int id)
        {
           return  table.Find(id);            
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj, int id)
        {
            var qs = table.Find(id);
            qs = obj;

           table.Update(qs);
            
            _context.SaveChanges();
           // table.Attach(obj);
            
            //_context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
