using BusinessEntities;
using BusinessEntities.Models;
using BusinessLayer;
using DataLayer;
using DataLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace GUI_WPF.Models
{
    class Campaign : INotifyPropertyChanged
    {
        public Campaign()
        {
            appDbContext = new AppDbContext();
            unitOfWork = new UnitOfWork(appDbContext);
            services = new Services(appDbContext, unitOfWork);
        }
        AppDbContext appDbContext { get; set; }
        UnitOfWork unitOfWork { get; set; }
        Services services { get; set; }

        private int campaignId;

        public int CampaignId
        {
            get { return campaignId; }
            set { campaignId = value; }
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        private DateTime created;

        public DateTime Created
        {
            get { return created; }
            set { created = value; }
        }

        private bool sent;

        public bool Sent
        {
            get { return sent; }
            set { sent = value; }
        }

        private int employeeId;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        private Employee creator;

        public Employee Creator
        {
            get { return creator; }
            set { creator = value; }
        }

      
        

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        
    }
  
}
