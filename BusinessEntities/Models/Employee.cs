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
    }
}
