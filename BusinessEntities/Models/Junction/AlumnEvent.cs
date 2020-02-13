using BusinessEntities;
using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Contexts.Junction
{
   public class AlumnEvent
    {
        public int AlumnId { get; private set; }
        public Alumn Alumn { get; private set; }

        public int EventId { get; private set; }
        public Event Event { get; private set; }
    }
}
