using BusinessEntities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models
{
    public class Competence
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public CompetenceLevel CompetenceLevel { get; set; }
    }
}
