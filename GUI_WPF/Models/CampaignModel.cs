using AutoMapper;
using BusinessEntities.Junction;
using BusinessEntities.Models;
using BusinessLayer;
using System;
using System.Collections.ObjectModel;

namespace GUI_WPF.Models
{
    public class CampaignModel
    {
        public CampaignModel()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Campaign, CampaignModel>();
                cfg.CreateMap<CampaignModel, Campaign>();
            });
            mapper = config.CreateMapper();
        }
        private IMapper mapper;
        private int _campaignId;
        private DateTime _created;
        private string _message;
        private bool _sent;
        private ObservableCollection<CampaignSubscribers> _subscribers;
        private Employee _creator;

        #region Properties
        public Employee Creator
        {
            get { return _creator; }
            set { _creator = value; }
        }

        public ObservableCollection<CampaignSubscribers> Subscribers
        {
            get { return _subscribers; }
            set { _subscribers = value; }
        }


        public bool Sent
        {
            get { return _sent; }
            set { _sent = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }


        public DateTime Created
        {
            get { return _created; }
            set { _created = value; }
        }

        public int CampaignId
        {
            get { return _campaignId; }
            set { _campaignId = value; }
        }
        #endregion

        internal ObservableCollection<CampaignModel> GetCampaigns(Services services, EmployeeModel employeeModel)
        {
            Employee employee = employeeModel.GetEmployee(services);
            ObservableCollection<CampaignModel> x = new ObservableCollection<CampaignModel>();
            foreach (var item in services.GetCollectionServices.GetCampaigns(employee))
            {
                CampaignModel campaignModel = mapper.Map<Campaign, CampaignModel>(item);
                x.Add(campaignModel);
            }
            return x;
        }

        internal void DeleteCampaign(Services services)
        {
            Campaign campaign = GetCampaign(services);
            services.DeleteServices.DeleteCampaign(campaign);
        }

        internal void UpdateCampaign(Services services)
        {
            Campaign campaign = GetCampaign(services);
            campaign.Message = Message;
            services.UpdateServices.UpdateCampaign(campaign);
        }

        internal Campaign GetCampaign(Services services)
        {
           return services.GetServices.GetCampaign(CampaignId);
        }

        internal void SaveCampaign(Services services, SubscriberList subscriberList)
        {
            Campaign NewCampaign = mapper.Map<CampaignModel, Campaign>(this);
            CampaignSubscribers campaignSubscribers = new CampaignSubscribers()
            {
                Campaign = NewCampaign,
                SubscriberList = subscriberList,
            };
            services.AddServices.AddCampaignSubscribers(campaignSubscribers);
        }
    }
}
