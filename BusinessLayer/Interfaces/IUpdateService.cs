using BusinessEntities.Models;

namespace BusinessLayer
{
    public interface IUpdateService
    {
        void UpdateAlumn(Alumn alumn);
        void UpdateCampaign(Campaign campaignId);
        void UpdateEmployee(Employee employee);
        void UpdateEvent(Event events);
    }
}