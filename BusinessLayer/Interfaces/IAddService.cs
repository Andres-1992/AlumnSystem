using BusinessEntities.Junction;
using BusinessEntities.Models;

namespace BusinessLayer
{
    public interface IAddService
    {
        void AddAlumn(Alumn alumn);
        void AddEvent(Event events);
        void AddSubscriberList(SubscriberList subscriberList);
        void AddSubscriberListAlumn(SubscriberListAlumn subscriberListAlumn);
        void AddCampaign(Campaign campaign);
        void AddCampaignSubscribers(CampaignSubscribers campaignSubscribers);
        void AddAlumnEvent(AlumnEvent alumnEvent);
    }
}