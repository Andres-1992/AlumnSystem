using BusinessEntities.Models;
using System.Collections.Generic;

namespace DataLayer
{
  public interface ICompetenceRepository:IGenericRepository<Competence>
    {
        IEnumerable<Competence> GetHighCompetences();
    }
}