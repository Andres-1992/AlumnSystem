using BusinessEntities;
using BusinessEntities.Junction;
using BusinessEntities.Models;
using DataLayer.Contexts.Junction;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Contexts
{
    public class AppDbContext : DbContext, IAppDbContext
    {

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

            //Ny modell

            modelBuilder.Entity<CampaignSubscribers>()
           .HasKey(a => new { a.CampaignId, a.SubscriberListId});

            modelBuilder.Entity<CampaignSubscribers>()
                .HasOne(ae => ae.SubscriberList)
                .WithMany(a => a.CampaignSubscribers)
                .HasForeignKey(ae => ae.SubscriberListId);

            modelBuilder.Entity<CampaignSubscribers>()
                .HasOne(ae => ae.Campaign)
                .WithMany(a => a.CampaignSubscribers)
                .HasForeignKey(ae => ae.CampaignId);

            //Ny modell

            modelBuilder.Entity<SubscriberListAlumn>()
           .HasKey(a => new { a.AlumnId, a.SubscriberListId });

            modelBuilder.Entity<SubscriberListAlumn>()
                .HasOne(ae => ae.SubscriberList)
                .WithMany(a => a.SubscriberListAlumn)
                .HasForeignKey(ae => ae.SubscriberListId);

            modelBuilder.Entity<SubscriberListAlumn>()
                .HasOne(ae => ae.Alumn)
                .WithMany(a => a.SubscriberListAlumn)
                .HasForeignKey(ae => ae.AlumnId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<AlumnEvent> AlumnEvent { get; set; }
        public DbSet<Alumn> Alumns { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Competence> Competence { get; set; }
        public DbSet<Campaign> Campaigns  { get; set; }
        public DbSet<SubscriberList> SubscriberLists { get; set; }
        public DbSet<CampaignSubscribers> CampaignSubscribers { get; set; }
        public DbSet<SubscriberListAlumn> SubscriberListAlumns { get; set; }

    }
}
