using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;

namespace BusinessLayer
{
    public class UpdateService : IUpdateService
    {
        AppDbContext AppDbContext;
        UnitOfWork UnitOfWork;

        public UpdateService(AppDbContext appDbContext, UnitOfWork unitOfWork)
        {
            AppDbContext = appDbContext;
            UnitOfWork = unitOfWork;
        }

        public void UpdateAlumn(Alumn alumn)
        {
            UnitOfWork.Alumns.Update(alumn);
            UnitOfWork.Alumns.Save();
        }

        public void UpdateCampaign(Campaign campaign)
        {
            AppDbContext.Campaigns.Update(campaign);
            AppDbContext.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            UnitOfWork.Employees.Update(employee);
            UnitOfWork.Employees.Save();
        }

        public void UpdateEvent(Event events)
        {
            UnitOfWork.Events.Update(events);
            UnitOfWork.Events.Save();
        }
    }
}
