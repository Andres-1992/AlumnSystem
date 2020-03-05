using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Car_12345
    {
        public int Id { get; set; }
        public string LicenseNumber { get; set; }
        public string Color { get; set; }

        public Person_12345 Person { get; set; }
    }
}
