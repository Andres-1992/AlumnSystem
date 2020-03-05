using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.Models;

namespace WpfApp3.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            Update();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Person> people;
        public ObservableCollection<Person> People
        {
            get { return people; }
            set { people = value;
                Changed();
            }
        }

        public void AddCarToCollection()
        {
            Person.Car.Add(new Car()
            {
                LicenseNumber = Car.LicenseNumber,
                Color = Car.Color
            });
        }

        public void DeletePerson(object selectedItem)
        {
            ((Person)selectedItem).Delete();
            Update();
        }

        public void DeleteCar(object selectedItem)
        {
            ((Car)selectedItem).Delete();
            Update();
        }

        public void SavePerson()
        {
            Person.Save();
            Update();
        }

        private Person person = new Person();
        public Person Person
        {
            get { return person; }
            set { person = value;
                Changed();
            }
        }

        private Car car = new Car();
        public Car Car
        {
            get { return car; }
            set { car = value;
                Changed();
            }
        }

        public void Update()
        {
            People = Person.GetPeople();
        }
    }
}
