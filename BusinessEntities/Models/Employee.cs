using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models
{
   public class Employee :Person
    {
        public int EmployeeId { get; private set; }
        public string Signature { get; private set; }

        public ICollection<Event> Events { get; private set; }

        public Employee(string name, string phonenumber, string email, string password,string signature)
        {

            Name = name;
            Phonenumber = phonenumber;
            Email = email;
            Password = password;
            Signature = signature;
        }

    }
}
