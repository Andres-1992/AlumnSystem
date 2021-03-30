using BusinessEntities.Enums;
using BusinessEntities.Junction;
using BusinessEntities.Models;
using BusinessLayer;
using Caliburn.Micro;
using GUI_WPF.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace GUI_WPF.ViewModels
{
    internal class CreateCampaignViewModel : Screen, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public CreateCampaignViewModel(Services services, EmployeeModel employeeModel)
        {
            Services = services;
            EmployeeModel = employeeModel;

        }

        private Services Services;
        private EmployeeModel EmployeeModel;
        private SubscriberList _subscriberList;

        private AlumnModel _alumnModel = new AlumnModel();
        private AlumnModel _selectedAlumn;
        private AlumnModel _selectedSubscriber;
        private ObservableCollection<AlumnModel> _alumns;
        private ObservableCollection<AlumnModel> _selectedAlumns = new ObservableCollection<AlumnModel>();

        private Education _selectedEducation;
        private ObservableCollection<Education> _educations = new ObservableCollection<Education>()
        { Education.Dataekonom,
                Education.Systemarkitekt,
                Education.Systemvetare};

        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #region Properties  


        public AlumnModel AlumnModel
        {
            get { return _alumnModel; }
            set { _alumnModel = value; Changed(); }
        }
        public ObservableCollection<Education> Educations
        {
            get { return _educations; }
            set { _educations = value; Changed(); }
        }
        public Education SelectedEducation
        {
            get { return _selectedEducation; }
            set { _selectedEducation = value; Changed(); }
        }
        public SubscriberList SubscriberList
        {
            get { return _subscriberList; }
            set { _subscriberList = value; Changed(); }
        }

        public AlumnModel SelectedSubscriber
        {
            get { return _selectedSubscriber; }
            set { _selectedSubscriber = value; Changed(); }
        }

        public ObservableCollection<AlumnModel> SelectedAlumns
        {
            get { return _selectedAlumns; }
            set { _selectedAlumns = value; Changed(); }
        }
        public ObservableCollection<AlumnModel> Alumns
        {
            get { return _alumns; }
            set { _alumns = value; Changed(); }
        }

        public AlumnModel SelectedAlumn
        {
            get { return _selectedAlumn; }
            set { _selectedAlumn = value; Changed(); }
        }
        #endregion
        public void ShowButton()
        {
            Alumns = AlumnModel.GetByAlumnsEducation(SelectedEducation, Services);
        }

        public void ShowAllButton()
        {
            Alumns = AlumnModel.GetAllAlumns(Services);
        }

        public void DeleteButton()
        {
            SelectedAlumns.Remove(SelectedSubscriber);
        }

        public void AddButton()
        {
            if (SelectedAlumn != null)
            {
                if (!SelectedAlumns.Any(x => x.AlumnId.Equals(SelectedAlumn.AlumnId)))
                {
                    SelectedAlumns.Add(SelectedAlumn);
                }
                    else MessageBox.Show($"Du kan inte lägga till {SelectedAlumn.Name} fler än en gång");
            }
                    else MessageBox.Show("Du måste välja nåt");                   
        }

        public void CreateSubListButton()
        {
            SubscriberList = new SubscriberList() { Created = DateTime.Now };
            Services.AddServices.AddSubscriberList(SubscriberList);
            SubscriberListAlumn SubscriberListAlumn = new SubscriberListAlumn();
            foreach (var item in SelectedAlumns)
            {
                SubscriberListAlumn.Alumn = item.GetAlumn(Services);
                SubscriberListAlumn.SubscriberList = SubscriberList;
                Services.AddServices.AddSubscriberListAlumn(SubscriberListAlumn);
            }
            MessageBox.Show("Du har skapat en ny Subscriber lista");
        }

        public bool CanCreateCampaignButton(string message)
        {
            if (String.IsNullOrWhiteSpace(message) || SubscriberList == null) return false;

            else return true;
        }

        public void CreateCampaignButton(string message)
        {
            CampaignModel CampaignModel = new CampaignModel()
            {
                Created = DateTime.Now,
                Creator = EmployeeModel.GetEmployee(Services),
                Message = message,
                Sent = true
            };
            CampaignModel.SaveCampaign(Services, SubscriberList);
            MessageBox.Show("Du har skapat ett utskick");
        }
    }
}

