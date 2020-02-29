using BusinessEntities.Enums;
using BusinessEntities.Junction;
using BusinessEntities.Models;
using DataLayer.Contexts.Junction;
using System.Collections.Generic;

namespace BusinessEntities
{
    public class Alumn : Person
    {
        public int AlumnId { get; private set; }
        public Education Education { get; private set; }
        public bool Work { get; private set; }

        public ICollection<AlumnEvent> AlumnEvents { get; private set; }
        public ICollection<Competence> Competences { get; set; }
        public ICollection<SubscriberListAlumn> SubscriberListAlumn { get; set; }

        public Alumn(string name, string email, string phonenumber, Education education, string password, bool work)
        {
            Name = name;
            Email = email;
            Phonenumber = phonenumber;
            Education = education;
            Password = password;
            Work = work;
        }
    }
}
