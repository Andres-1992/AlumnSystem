using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public DateTime LastDate { get; set; }
    }
}