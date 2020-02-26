using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Junction
{
    public class CampaignSubscribers
    {
        public int CampaignId { get; set; }
        public Campaign Campaign { get; set; }

        public int SubscriberListId { get; set; }
        public SubscriberList SubscriberList { get; set; }
    }
}
