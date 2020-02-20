using BusinessEntities;
using BusinessEntities.Enums;
using BusinessEntities.Models;
using DataLayer.Contexts.Junction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Contexts
{
    public class AppDbContext : DbContext, IAppDbContext
    {

       private static AppDbContext appDbContext { get; set; }
        public static AppDbContext GetInstance()
        {
            if (appDbContext == null)
            {
                appDbContext = new AppDbContext();
                return appDbContext;
            }
            return appDbContext;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=sqlutb2.hb.se,56077;database=osu2003;User id=osu2003;password=wb2538;Integrated Security=false;");
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlumnEvent>()
                .HasKey(a => new { a.AlumnId, a.EventId });

            modelBuilder.Entity<AlumnEvent>()
                .HasOne(ae => ae.Alumn)
                .WithMany(a => a.AlumnEvents)
                .HasForeignKey(ae => ae.AlumnId);

            modelBuilder.Entity<AlumnEvent>()
                .HasOne(ae => ae.Event)
                .WithMany(a => a.AlumnEvents)
                .HasForeignKey(ae => ae.EventId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<AlumnEvent> AlumnEvent { get; set; }
        public DbSet<Alumn> Alumns { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Competence> Competence { get; set; }

    }
}
