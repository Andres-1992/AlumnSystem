using BusinessEntities.Enums;
using Caliburn.Micro;
using GUI_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Linq;

namespace GUI_WPF.ViewModels
{
    class CreateCampaignViewModel : Screen ,  INotifyPropertyChanged
    {

        

        public CreateCampaignViewModel()
        {
          
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Alumn> alumns;

        public ObservableCollection<Alumn> Alumns
        {
            get { return alumns; }
            set { alumns = value; Changed(); }
        }

        

        private Alumn alumn = new Alumn();

        public Alumn Alumn
        {
            get { return alumn; }
            set { alumn = value; Changed(); }
        }

        private Alumn _selectedAlumn;

        public Alumn SelectedAlumn
        {
            get { return _selectedAlumn; }
            set { _selectedAlumn = value; Changed(); }
        }

        private ObservableCollection<Alumn> _selectedAlumns = new ObservableCollection<Alumn>();

        public ObservableCollection<Alumn> SelectedAlumns
        {
            get { return _selectedAlumns; }
            set { _selectedAlumns = value; Changed(); }
        }

        private Alumn _selectedSubscriber;

        public Alumn SelectedSubscriber
        {
            get { return _selectedSubscriber; }
            set { _selectedSubscriber = value; Changed(); }
        }

        private ObservableCollection<SubscriberList> _subscriberList = new ObservableCollection<SubscriberList>();

        public ObservableCollection<SubscriberList> SubscriberList
        {
            get { return _subscriberList; }
            set { _subscriberList = value; Changed(); }
        }

        private Education _selectedEducation;

        public Education SelectedEducation
        {
            get { return _selectedEducation; }
            set { _selectedEducation = value; }
        }

        public void CreateListButton()
        {
            

        }

        public void ShowButton()
        {
            Alumns = Alumn.GetByEducation(SelectedEducation);
        }

        public void ShowAllButton()
        {
            Alumns = Alumn.GetAlumns();
            

        }
        public void DeleteButton()
        {
            SelectedAlumns.Remove(SelectedSubscriber);
        }

        public void AddButton()
        {
            
            if (!SelectedAlumns.Any(x => x.AlumnId.Equals(SelectedAlumn.AlumnId)))
            {
                SelectedAlumns.Add(SelectedAlumn);
            }
            else MessageBox.Show($"Du inte lägga till {SelectedAlumn.Name} fler än en gång");

        }
       
    
    }
  
}
