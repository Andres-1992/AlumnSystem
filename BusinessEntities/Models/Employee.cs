using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models
{
   public class Employee :Person
    {
        public int EmployeeId { get;  set; }
        public string Signature { get;  set; }
        public ICollection<Event> Events { get; set; }

        
        public Employee(string name, string phonenumber, string email)
        {
            
            Name = name;
            Phonenumber = phonenumber;
            Email = email;
        }
    }
   

}
