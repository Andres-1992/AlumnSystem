using BusinessEntities;
using BusinessEntities.Models;

namespace BusinessEntities.Junction
{
    public class AlumnEvent
    {
        public int AlumnId { get; set; }
        public Alumn Alumn { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
