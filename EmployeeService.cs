using BusinessEntities;
using BusinessEntities.Enums;
using BusinessEntities.Junction;
using BusinessEntities.Models;
using DataLayer;
using DataLayer.Contexts;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Tracing;

namespace BusinessLayer
{
    public class EmployeeService : IEmployeeService
    {
        AppDbContext AppDbContext;
        UnitOfWork UnitOfWork;

        public EmployeeService(AppDbContext appDbContext, UnitOfWork unitOfWork)
        {
            AppDbContext = appDbContext;
            UnitOfWork = unitOfWork;
        }

        public void AddEvent(Event events)
        {
            UnitOfWork.Events.Insert(events);
            UnitOfWork.Events.Save();
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

        public IEnumerable<Alumn> GetAlumnsByEducation(Education education)
        {
            return UnitOfWork.Alumns.GetAlumnsByEducation(education);
        }

        public IEnumerable<Alumn> GetAll()
        {
            return UnitOfWork.Alumns.GetAll();
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

        public void RemoveEvent(int id)
        {
            UnitOfWork.Events.Delete(id);
            UnitOfWork.Events.Save();
        }

        public Event GetEventById(int id)
        {
            return UnitOfWork.Events.GetById(id); 
        }

        public Employee GetEmployee(int id)
        {
            return UnitOfWork.Employees.GetById(id);
        }

        
        public IEnumerable<Alumn> GetAttendedAlumn(Event events)
        {
            return UnitOfWork.Events.GetAttendedAlumn(events);
        }

        
    }
}
