using BusinessEntities.Junction;
using System;
using System.Collections.Generic;

namespace BusinessEntities.Models
{
    public class SubscriberList
    {
        public int SubscriberListId { get; set; }
        public DateTime Created { get; set; }

        public ICollection<CampaignSubscribers> CampaignSubscribers { get; set; }
        public ICollection<SubscriberListAlumn> SubscriberListAlumn { get; set; }

    }

}
