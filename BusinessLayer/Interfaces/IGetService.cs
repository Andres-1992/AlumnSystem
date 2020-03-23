using BusinessEntities.Models;

namespace BusinessLayer
{
    public interface IGetService
    {
        Alumn GetAlumn(int id);
        Event GetEvent(int id);
        Employee GetEmployee(int id);
        Campaign GetCampaign(int id);
    }
}
