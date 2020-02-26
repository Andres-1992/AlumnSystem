using BusinessEntities.Junction;
using System;
using System.Collections.Generic;

namespace BusinessEntities.Models
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
        public bool Sent { get; set; }

        public int EmployeeID { get; set; }
        public Employee Creator { get; set; }        
        public ICollection<CampaignSubscribers> CampaignSubscribers { get; set; }
    }
}
