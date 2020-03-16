using BusinessLayer;
using Caliburn.Micro;
using GUI_WPF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace GUI_WPF.ViewModels
{
    public class DeleteAccountViewModel:Screen
    {
        Services Services { get; set; }
        AlumnModel AlumnModel { get; set; }
        public DeleteAccountViewModel(Services services, AlumnModel alumnModel)
        {
            Services = services;
            AlumnModel = alumnModel;
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value;  }
        }


        public void Delete(string password)
        {
            if (Services.LogInServices.Encrypt(password)==AlumnModel.Password)
            {                
                Services.DeleteServices.DeleteAlumn(AlumnModel.AlumnId);
                IWindowManager manager = new WindowManager();
                manager.ShowWindow(new LogInViewModel(),null,null) ;               
                TryClose();
            }
            else
            {
                MessageBox.Show("Fel lösenord");
            }
        }
    }
}
