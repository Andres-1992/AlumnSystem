using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class GetService : IGetService
    {
        AppDbContext AppDbContext;
        UnitOfWork UnitOfWork;

        public GetService(AppDbContext appDbContext, UnitOfWork unitOfWork)
        {
            AppDbContext = appDbContext;
            UnitOfWork = unitOfWork;
        }

        public Alumn GetAlumn(int id)
        {
           return UnitOfWork.Alumns.GetById(id);
        }

        public Campaign GetCampaign(int campaignId)
        {
            return AppDbContext.Campaigns.Find(campaignId);
        }

        public Employee GetEmployee(int id)
        {
            return UnitOfWork.Employees.GetById(id);
        }

        public Event GetEvent(int id)
        {
            return UnitOfWork.Events.GetById(id);
        }
    }
}
