using BusinessLayer;
using Caliburn.Micro;
using GUI_WPF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace GUI_WPF.ViewModels
{
   public class LoggedInAlumnViewModel: Conductor<object>
    {
        AlumnModel AlumnModel { get; set; }
        Services Services { get; set; }
        public LoggedInAlumnViewModel(Services services,AlumnModel alumnModel)
        {
            AlumnModel = alumnModel;
            Services = services;
        }
        public void ChangeInfo()
        {
            ActivateItem(new UpdateAlumnViewModel(Services,AlumnModel));
        }

        public void AttendEvent()
        {
            ActivateItem(new AttendEventViewModel(Services, AlumnModel));

        }
        public void Logout()
        {
            LogInViewModel logInViewModel= new LogInViewModel();

            IWindowManager manager = new WindowManager();
            manager.ShowWindow(logInViewModel);
            TryClose();
        }
        public void DeleteAccount()
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new DeleteAccountViewModel(Services,AlumnModel));
            TryClose();
        }
    }
}
