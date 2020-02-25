using BusinessEntities;
using BusinessEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Contexts
{
    public interface IAppDbContext
    {
        DbSet<Alumn> Alumns { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<Competence> Competence { get; set; }
    }
}