using DataLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Models
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private int id;
        private string firstname;
        private string lastname;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value;
                Changed();
            }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value;
                Changed();
            }
        }

        private ObservableCollection<Car> car = new ObservableCollection<Car>();
        public ObservableCollection<Car> Car
        {
            get { return car; }
            set { car = value;
                Changed();
            }
        }

        public static ObservableCollection<Person> GetPeople()
        {
            ObservableCollection<Person> x = new ObservableCollection<Person>();
            foreach (var item in DataManager.PeopleGet())
            {
                Person person = new Person()
                {
                    Id = item.Id,
                    Firstname = item.Firstname,
                    Lastname = item.Lastname,
                };

                foreach (var car in item.Cars)
                {
                    person.Car.Add(new Car()
                    {
                        LicenseNumber = car.LicenseNumber,
                        Color = car.Color
                    });
                }

                x.Add(person);
            }

            return x;
        }

        public void Save()
        {
            DataLayer.Person_12345 newPerson = new DataLayer.Person_12345()
            {
                Firstname = this.Firstname,
                Lastname = this.Lastname
            };

            foreach (var item in this.Car)
            {
                newPerson.Cars.Add(new DataLayer.Car_12345()
                {
                    LicenseNumber = item.LicenseNumber,
                    Color = item.Color
                });
            }

            DataManager.PersonSave(newPerson);
        }

        public void Delete()
        {
            DataManager.PersonDelete(Id);
        }
    }
}
