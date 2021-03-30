using BusinessEntities.Enums;

namespace BusinessEntities.Models
{
    public class Competence
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public CompetenceLevel CompetenceLevel { get; set; }

        public int AlumnId { get; set; }
        public Alumn Alumn { get; set; }

        public Competence(string description, CompetenceLevel competenceLevel)
        {
            Description = description;
            CompetenceLevel = competenceLevel;
        }

    }
}
