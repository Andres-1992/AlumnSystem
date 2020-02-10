using BusinessEntities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Contexts
{
    public class EventContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Event;Integrated Security=True");
            base.OnConfiguring(optionsBuilder); 
        }
        public DbSet<Event> events { get; set; }
    }
}
