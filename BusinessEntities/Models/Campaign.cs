using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models
{
    public class Campaign
    {
        public ICollection<SubscriberList> subscriberLists { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
        public bool Sent { get; set; }
        public Employee Creator { get; set; }
    }
    
    
}
