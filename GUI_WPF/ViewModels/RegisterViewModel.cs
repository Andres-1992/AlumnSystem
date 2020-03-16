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
using System.Windows;

namespace GUI_WPF.ViewModels
{
    public class RegisterViewModel
    {
        Services Services { get; set; }
        public RegisterViewModel(Services services)
        {
            Services = services;
        }
        private ObservableCollection<CompetenceLevel> _competenceLevels = new ObservableCollection<CompetenceLevel>() { CompetenceLevel.Low, CompetenceLevel.Medium, CompetenceLevel.High };
        private ObservableCollection<Education> _educations = new ObservableCollection<Education> { Education.Dataekonom, Education.Systemarkitekt, Education.Systemvetare };
        private AlumnModel _alumn = new AlumnModel();
        private CompetenceLevel _selectedCompetenceLevel;
        private Education _selectedEducation;
        private ObservableCollection<Competence> _competences = new ObservableCollection<Competence>();
        #region Properties
        public ObservableCollection<CompetenceLevel> CompetenceLevels

        {
            get { return _competenceLevels; }
            set { _competenceLevels = value; }
        }
        public ObservableCollection<Education> Educations
        {
            get { return _educations; }
            set { _educations = value; Changed(); }
        }
        public AlumnModel Alumn
        {
            get { return _alumn; }
            set { _alumn = value; Changed(); }
        }
        public CompetenceLevel SelectedCompetenceLevel
        {
            get { return _selectedCompetenceLevel; }
            set { _selectedCompetenceLevel = value; Changed(); }
        }
        public Education SelectedEducation
        {
            get { return _selectedEducation; }
            set { _selectedEducation = value; Changed(); }
        }
        public ObservableCollection<Competence> Competences
        {
            get { return _competences; }
            set { _competences = value; Changed(); }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddAlumn(string confirmPassword)

        {
            if (confirmPassword == Alumn.Password)
            {
                AlumnModel alumnModel = new AlumnModel()
                {
                    Name = Alumn.Name,
                    Email = Alumn.Email,
                    Phonenumber = Alumn.Phonenumber,
                    Education = SelectedEducation,
                    Password = Services.LogInServices.Encrypt(Alumn.Password),
                    Work = Alumn.Work
                };
                alumnModel.Competences = Competences;
                alumnModel.SaveAlumn(Services);
                MessageBox.Show("Du är registrerad");
            }
            else MessageBox.Show("Du angav fel lösenord");
        }

        public bool CanAddCompetenceButton(string description)
        {
            if (String.IsNullOrEmpty(description))
            {
                return false;
            }
            else return true;
        }
        public void AddCompetenceButton(string description)
        {
            Competences.Add(new Competence(description, SelectedCompetenceLevel));
            MessageBox.Show("Du har lagt till en ny kompetens");
        }

    }
}
