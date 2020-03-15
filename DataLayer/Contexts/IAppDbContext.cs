

using BusinessEntities.Junction;
using BusinessEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Contexts
{
    public interface IAppDbContext
    {
        public DbSet<AlumnEvent> AlumnEvent { get; set; }
        public DbSet<Alumn> Alumns { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Competence> Competence { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<SubscriberList> SubscriberLists { get; set; }
        public DbSet<CampaignSubscribers> CampaignSubscribers { get; set; }
        public DbSet<SubscriberListAlumn> SubscriberListAlumns { get; set; }
    }
}