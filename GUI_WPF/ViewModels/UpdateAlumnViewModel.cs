using AutoMapper;
using BusinessEntities.Enums;
using BusinessEntities.Models;
using BusinessLayer;
using GUI_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Linq;

namespace GUI_WPF.ViewModels
{
    public class UpdateAlumnViewModel : INotifyPropertyChanged
    {
        Services Services { get; set; }

        public UpdateAlumnViewModel(Services services, AlumnModel alumnModel)
        {
            Services = services;
            AlumnModel = alumnModel;
            LoadCompetences();
        }

        private AlumnModel _alumnModel;
        private ObservableCollection<Competence> _competences = new ObservableCollection<Competence>();
        private ObservableCollection<CompetenceLevel> _competenceLevels = new ObservableCollection<CompetenceLevel>()
        {CompetenceLevel.Low,CompetenceLevel.Medium, CompetenceLevel.High};
        private string _currentPassword;
        private string _newPassword;
        private CompetenceLevel _selectedCompetenceLevel;
        #region properties
        public CompetenceLevel SelectedCompetenceLevel
        {
            get { return _selectedCompetenceLevel; }
            set { _selectedCompetenceLevel = value; }
        }

        public string NewPassword
        {
            get { return _newPassword; }
            set { _newPassword = value; Changed(); }
        }

        public string CurrentPassword
        {
            get { return _currentPassword; }
            set { _currentPassword = value; Changed(); }
        }

        public ObservableCollection<CompetenceLevel> CompetenceLevels
        { get { return _competenceLevels; } set { _competenceLevels = value; Changed(); } }

        public AlumnModel AlumnModel
        {
            get { return _alumnModel; }
            set { _alumnModel = value;  }
        }

        public ObservableCollection<Competence> Competences
        {
            get { return _competences; }
            set { _competences = value; Changed(); }
        }
        #endregion

        public void AddCompetence(string descriptionComp)
        {
            Competences.Add(new Competence(descriptionComp, SelectedCompetenceLevel)); ;
        }

        public void UpdateInfo(string currentPassword, string newPassword)
        {
            if (Services.BusinessManager.Encrypt(currentPassword) == AlumnModel.Password)
            {
                AlumnModel.Password = Services.BusinessManager.Encrypt(newPassword);
            }
            AlumnModel.UpdateAlumn(Services, Competences);
            CurrentPassword = "";
            NewPassword = "";
            LoadCompetences();
        }
        
        private void LoadCompetences()
        {
            Competences = AlumnModel.GetCompetences(Services);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
