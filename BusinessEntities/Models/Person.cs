using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models
{
    public abstract class Person
    {
        public string Name { get;  set; }
        public string Email { get;  set; }
        public string Phonenumber { get;  set; }
    }
}
