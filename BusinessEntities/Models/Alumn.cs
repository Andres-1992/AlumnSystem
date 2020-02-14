using BusinessEntities.Models;
using DataLayer.Contexts.Junction;
using System;
using System.Collections.Generic;

namespace BusinessEntities
{
    public class Alumn : Person
    {
        public int AlumnId { get; private set; }
        public string Education { get; private set; }
        public ICollection<AlumnEvent> AlumnEvents { get; private set; }
        public string Password {  get; private set; }
        //public bool Arbetslivserfarenhet { get; set; }
        //public List<Alumn> erfarenhet = new List<Alumn>();

        public Alumn(string name, string email,string phonenumber , string education, string password)
        {
            Name = name;
            Email = email;
           Phonenumber = phonenumber;
            Education = education;
            Password = password;
        }
    }
}
