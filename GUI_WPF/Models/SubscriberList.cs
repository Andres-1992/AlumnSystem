using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using BusinessLayer;
using DataLayer;
using DataLayer.Contexts;


namespace GUI_WPF.Models
{
    class SubscriberList : INotifyPropertyChanged
    {

        public SubscriberList()
        {
            appDbContext = new AppDbContext();
            unitOfWork = new UnitOfWork(appDbContext);
            services = new Services(appDbContext, unitOfWork);
        }
        AppDbContext appDbContext { get; set; }
        UnitOfWork unitOfWork { get; set; }
        Services services { get; set; }

        


        private int _subscriberListId;

        public int SubscriberListId
        {
            get { return _subscriberListId; }
            set { _subscriberListId = value; }
        }

        private DateTime _created;

        public DateTime Created
        {
            get { return _created; }
            set { _created = value; }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
