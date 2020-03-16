using BusinessLayer;
using GUI_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace GUI_WPF.ViewModels
{

    public class EditCampaignViewModel : INotifyPropertyChanged
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

        #region Properties
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
        #endregion

        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void LoadCampaigns()
        {
            Campaigns = CampaignModel.GetCampaigns(Services, EmployeeModel);
        }
        public void DeleteCampaign()
        {
            if (SelectedCampaign == null) MessageBox.Show("Du måste välja en kampanj");

            else
            {
                SelectedCampaign.DeleteCampaign(Services);
                LoadCampaigns();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public void Update()
        {
            if (SelectedCampaign == null) MessageBox.Show("Du måste välja en kampanj");

            else
            {
                SelectedCampaign.UpdateCampaign(Services);
                LoadCampaigns();
            }

        }

    }
}
