using BusinessLayer;
using Caliburn.Micro;
using DataLayer;
using DataLayer.Contexts;
using GUI_WPF.Models;
using GUI_WPF.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace GUI_WPF.ViewModels
{
    class LogInViewModel : Screen
    {
        AppDbContext appDbContext { get; set; }
        UnitOfWork unitOfWork { get; set; }
        Services Services { get; set; }
        public LogInViewModel()
        {
            appDbContext = new AppDbContext();
            unitOfWork = new UnitOfWork(appDbContext);
            Services = new Services(appDbContext, unitOfWork);
        }

        IWindowManager manager = new WindowManager();
        private string _userVerification;
        private string _idInput;
        private string _password;
        private EmployeeModel _employee = new EmployeeModel();
        private AlumnModel _alumn = new AlumnModel();

       
        public event PropertyChangedEventHandler PropertyChanged;

        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #region Properties
        public EmployeeModel Employee
        {
            get { return _employee; }
            set { _employee = value; NotifyOfPropertyChange(() => Employee); }
        }

        public AlumnModel Alumn
        {
            get { return _alumn; }
            set { _alumn = value; NotifyOfPropertyChange(() => Alumn); }
        }

        public string UserVerification
        {
            get { return _userVerification; }
            set { _userVerification = value; NotifyOfPropertyChange(() => UserVerification); ; }
        }

        public string IdInput
        {
            get { return _idInput; }
            set { _idInput = value; NotifyOfPropertyChange(() => IdInput); }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; NotifyOfPropertyChange(() => Password); }
        }
        #endregion


        public void RegisterLink()
        {
            manager.ShowWindow(new RegisterViewModel(Services), null, null);
        }

        public void LogInButton(string idInput, string password)
        {
            if (UserVerification == "Signatur")
            {
                EmployeeModel loggedInEmployee = Employee.GetLoggedInEmployee(idInput, password, Services);
                if (loggedInEmployee != null)
                {
                    manager.ShowWindow(new LoggedInEmployeeViewModel(Services, loggedInEmployee), null, null);
                    TryClose();
                }
                else MessageBox.Show("Signatur eller lösenord stämmer inte");

            }
            else if (UserVerification == "Email")
            {                
                AlumnModel loggedInAlumn = Alumn.GetLoggedInAlumn(idInput, password, Services);
                if (loggedInAlumn != null)
                {                 
                    manager.ShowWindow(new LoggedInAlumnViewModel(Services, loggedInAlumn), null, null);
                    TryClose();
                }
                else MessageBox.Show("Email eller lösenord stämmer inte");
            }

            else MessageBox.Show("Du har inte valt alumn eller personal");
        }
        public void EmployeeCheckBox(string idInput, string password)
        {
            ChangeUserVerification("Signatur");
            IdInput = "";
            Password = "";
        }

        public void AlumnCheckBox(string idInput, string password)
        {
            ChangeUserVerification("Email");
            IdInput = "";
            Password = "";
        }

        private void ChangeUserVerification(string s)
        {
            UserVerification = s;
        }

        public bool CanLogInButton(string idInput, string password)
        {
            if (String.IsNullOrWhiteSpace(idInput) || String.IsNullOrWhiteSpace(password))
            {

                return false;
            }
            else return true;
        }

    }
}
