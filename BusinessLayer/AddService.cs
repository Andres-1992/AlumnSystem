using BusinessEntities.Junction;
using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class AddService : IAddService
    {
        AppDbContext AppDbContext;
        UnitOfWork UnitOfWork;
        public AddService(AppDbContext appDbContext, UnitOfWork unitOfWork)
        {
            AppDbContext = appDbContext;
            UnitOfWork = unitOfWork;
        }
        public void AddAlumn(Alumn alumn)
        {
            UnitOfWork.Alumns.Insert(alumn);
            UnitOfWork.Alumns.Save();
        }

        public void AddAlumnEvent(AlumnEvent alumnEvent)
        {
            AppDbContext.AlumnEvent.Add(alumnEvent);
            AppDbContext.SaveChanges();
        }

        public void AddCampaign(Campaign campaign)
        {
            AppDbContext.Campaigns.Add(campaign);
            AppDbContext.SaveChanges();
        }

        public void AddCampaignSubscribers(CampaignSubscribers campaignSubscribers)
        {
            AppDbContext.CampaignSubscribers.Add(campaignSubscribers);
            AppDbContext.SaveChanges();
        }

        public void AddEvent(Event events)
        {
            UnitOfWork.Events.Insert(events);
            UnitOfWork.Events.Save();
        }

        public void AddSubscriberList(SubscriberList subscriberList)
        {
            AppDbContext.SubscriberLists.Add(subscriberList);
            AppDbContext.SaveChanges();
        }

        public void AddSubscriberListAlumn(SubscriberListAlumn subscriberListAlumn)
        {
            AppDbContext.SubscriberListAlumns.Add(subscriberListAlumn);
            AppDbContext.SaveChanges();
        }
    }
}
