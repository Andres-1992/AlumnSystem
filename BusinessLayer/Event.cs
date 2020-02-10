using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class Event : IEvent
    {
        public string Name { get; set; }
        public int EventId { get; set; }
        
    }
}
