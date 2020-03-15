using BusinessLayer;
using GUI_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace GUI_WPF.ViewModels
{

    public class EditCampaignViewModel:INotifyPropertyChanged
    {

        Services Services { get; set; }
        EmployeeModel EmployeeModel { get; set; }
        public EditCampaignViewModel(Services services, EmployeeModel employeeModel)
        {
            Services = services;
            EmployeeModel = employeeModel;
            LoadCampaigns();
        }

        private ObservableCollection<CampaignModel> _campaigns;
        private CampaignModel _selectedCampaign;
        private CampaignModel _campaignModel = new CampaignModel();

        public ObservableCollection<CampaignModel> Campaigns
        {
            get { return _campaigns; }
            set { _campaigns = value; Changed(); }
        }
        public CampaignModel SelectedCampaign
        {
            get { return _selectedCampaign; }
            set { _selectedCampaign = value; Changed(); }
        }
        public CampaignModel CampaignModel
        {
            get { return _campaignModel; }
            set { _campaignModel = value; Changed(); }
        }
        
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void LoadCampaigns()
        {            
            Campaigns = CampaignModel.GetCampaigns(Services,EmployeeModel);
        }
        public void DeleteCampaign()
        {
            SelectedCampaign.DeleteCampaign(Services);
            LoadCampaigns();
        }
       
        public event PropertyChangedEventHandler PropertyChanged;


        public void Update()
        {
            SelectedCampaign.UpdateCampaign(Services);
            LoadCampaigns();
        }

    }
}
