using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Employee : IEmployee
    {
        public string Signature { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
    }
}
