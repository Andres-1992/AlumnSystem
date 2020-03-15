using BusinessLayer;
using Caliburn.Micro;
using GUI_WPF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GUI_WPF.ViewModels
{
   public class LoggedInEmployeeViewModel:Conductor<object>
    {
        Services Services { get; set; }
        EmployeeModel EmployeeModel { get; set; }
        
        public LoggedInEmployeeViewModel(Services services,EmployeeModel employeeModel)
        {
            Services = services;
            EmployeeModel = employeeModel;
        }
        public void CreateEvent()
        {
            ActivateItem(new AddEventViewModel(Services,EmployeeModel));
        }
        public void ChangeInfo()
        {
            ActivateItem(new UpdateEmployeeViewModel(Services,EmployeeModel));
        }
        public void CreateCampaign()
        {
            ActivateItem(new CreateCampaignViewModel(Services,EmployeeModel));
        }
        public void EditCampaign()
        {
            ActivateItem(new EditCampaignViewModel(Services, EmployeeModel));

        }
        public void LogOut()
        {
            LogInViewModel logInViewModel = new LogInViewModel();

            IWindowManager manager = new WindowManager();
            manager.ShowWindow(logInViewModel);
            TryClose();
        }
    }
}
