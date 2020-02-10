using System;

namespace BusinessEntities
{
    public class Alumn
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Education;
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Alumn(string name)
        {
            Name = name;
        }
    }
}