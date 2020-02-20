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
        public bool sent { get; set; }
    }
    public class test2
    {
        test1 testclass = new test1();
        Campaign campaign = new Campaign()
        {
            subscriberLists = new List<SubscriberList>(),
            Message = "Alla kommer hem till JJ",
            Created = DateTime.Now,
            sent=true
        };
        public void göringet()
        {
            campaign.subscriberLists.Add(testclass.GetSubscriberList()) ;
        }
        
    }

    public class test1
    {
        SubscriberList subscriberList = new SubscriberList()
        {
            alumns = new List<Alumn>()
            {
                new Alumn("Jojo", "jj@student.se", "02000", Enums.Education.Systemarkitekt, "password", true),
                new Alumn("Jaha", "jaha@student.se", "02000", Enums.Education.Dataekonom, "password", false)
            },
            Created = DateTime.Now
        };

        public SubscriberList GetSubscriberList()
        {
            return subscriberList;
        }
    }
}
