using BusinessEntities.Junction;
using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;

namespace BusinessLayer
{
    public class DeleteService : IDeleteService
    {
        AppDbContext AppDbContext;
        UnitOfWork UnitOfWork;
        public DeleteService(AppDbContext appDbContext, UnitOfWork unitOfWork)
        {
            AppDbContext = appDbContext;
            UnitOfWork = unitOfWork;
        }
        public void DeleteAlumn(int id)
        {
            UnitOfWork.Alumns.Delete(id);
            UnitOfWork.Alumns.Save();
        }

        public void DeleteCampaign(Campaign campaign)
        {
            AppDbContext.Campaigns.Remove(campaign);
            AppDbContext.SaveChanges();
        }

        public void DeleteEvent(int id)
        {
            UnitOfWork.Events.Delete(id);
            UnitOfWork.Events.Save();
        }

        public void RemoveMyEvent(AlumnEvent alumnEvent)
        {
            AppDbContext.AlumnEvent.Remove(alumnEvent);
            AppDbContext.SaveChanges();
        }

    }
}
