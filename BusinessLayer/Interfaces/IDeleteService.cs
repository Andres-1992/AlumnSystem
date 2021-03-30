using BusinessEntities.Junction;
using BusinessEntities.Models;

namespace BusinessLayer
{
    public interface IDeleteService
    {
        void DeleteAlumn(int id);
        void RemoveMyEvent(AlumnEvent alumnEvent);
        void DeleteEvent(int id);
        void DeleteCampaign(Campaign campaignId);
    }
}