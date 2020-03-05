using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Person_12345
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public ICollection<Car_12345> Cars { get; set; }

        public Person_12345()
        {
            Cars = new List<Car_12345>();
        }
    }
}
