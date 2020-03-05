using Caliburn.Micro;
using GUI_WPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using BusinessEntities.Enums;
using System.Media;
using System.Collections.ObjectModel;

namespace GUI_WPF.ViewModels
{
    public class RegisterAlumnViewModel : Screen
    {
        ObservableCollection<Competence> competences = new ObservableCollection<Competence>();
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddAlumn()

        {

            Alumn alumn = new Alumn()
            {
                Name = Alumn.Name,
                Email = Alumn.Email,
                Phonenumber = Alumn.Phonenumber,
                Education = SelectedEducation,
                Password = Alumn.Password,
                Work = Alumn.Work


            };
            alumn.Competences = competences;
            alumn.SaveAlumn();
            Changed();
        }


        private Alumn _alumn = new Alumn();

        public Alumn Alumn
        {
            get { return _alumn; }
            set
            {
                _alumn = value;
                Changed();
            }
        }
        private Competence _competence = new Competence();

        public Competence Competence
        {
            get { return _competence; }
            set
            {
                _competence = value;
                Changed();
            }
        }
        private Education _selectedEducation;
        public Education SelectedEducation
        {
            get { return _selectedEducation; }
            set { _selectedEducation = value; Changed(); }
        }
        private CompetenceLevel _selectedCompetenceLevel;

        public CompetenceLevel SelectedCompetenceLevel
        {
            get { return _selectedCompetenceLevel; }
            set
            {
                _selectedCompetenceLevel = value; Changed();
            }
        }
      
        public void AddCompetenceButton()
        {
            Competence competence = new Competence()
            {
                Description = Competence.Description,
                CompetenceLevel = SelectedCompetenceLevel
            };
            competences.Add(competence);
        }


        //public void GDPRcheckBox()
        //{

        //    MessageBox.Show("Genom att kryssa i rutan samtycker du till att Högskolan i Borås," +
        //          " behandlar personuppgifter om dig, i enlighet med vår integritetspolicy. Vi använder uppgifter om dig för att kunna nå dig med information," +
        //          " erbjudanden och relevant innehåll. Du kan närsomhelst avregistrera dig från dessa.");
        //}
    }

}