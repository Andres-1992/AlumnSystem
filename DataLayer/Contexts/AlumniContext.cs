﻿using BusinessEntities;
using BusinessEntities.Models;
using DataLayer.Contexts.Junction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Contexts
{
    public class AlumniContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=sqlutb2.hb.se,56077;database=osu2003;User id=osu2003;password=wb2538;Integrated Security=false");
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

        public DbSet<Alumn> Alumns { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }

    }
}