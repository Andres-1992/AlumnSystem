﻿using BusinessEntities;
using BusinessEntities.Enums;
using BusinessEntities.Junction;
using BusinessEntities.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BusinessLayer
{
    public interface IEmployeeService
    {
        void AddEvent(Event events);
        void UpdateEmployee(Employee employee);
        void UpdateEvent(Event events);
        IEnumerable<Alumn> GetAlumnsByEducation(Education education);
        IEnumerable<Alumn> GetAll();

        IEnumerable<Alumn> GetAttendedAlumn(Event events);
        void AddSubscriberList(SubscriberList subscriberList);
        void AddSubscriberListAlumn(SubscriberListAlumn subscriberListAlumn);
        void AddCampaign(Campaign campaign);
        void AddCampaignSubscribers(CampaignSubscribers campaignSubscribers);
        void RemoveEvent(int id);
        Event GetEventById(int id);
        Employee GetEmployee(int id);
        
    }
}