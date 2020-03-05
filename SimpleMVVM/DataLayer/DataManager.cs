using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataManager
    {
        public static void PersonSave(Person_12345 person)
        {
            using (var db = new AppDbContext())
            {
                db.People.Add(person);
                db.SaveChanges();
            }
        }

        public static void PersonDelete(int id)
        {
            using (var db = new AppDbContext())
            {
                db.People.RemoveRange(db.People.Where(x => x.Id == id));
                db.SaveChanges();
            }
        }

        public static ObservableCollection<Person_12345> PeopleGet()
        {
            var db = new AppDbContext();
            return new ObservableCollection<Person_12345>(
                db.People.Include(x => x.Cars).ToList()
            );
        }

        public static ObservableCollection<Car_12345> CarsGet()
        {
            var db = new AppDbContext();
            return new ObservableCollection<Car_12345>(
                db.Cars.ToList()
            );
        }

        public static ObservableCollection<Car_12345> CarsGet(int Id)
        {
            var db = new AppDbContext();
            return new ObservableCollection<Car_12345>(
                db.Cars.Where(x => x.Id == Id).ToList()
            );
        }

        public static void CarDelete(string LicenseNumber)
        {
            using (var db = new AppDbContext())
            {
                db.Cars.RemoveRange(db.Cars.Where(x => x.LicenseNumber == LicenseNumber));
                db.SaveChanges();
            }
        }
    }
}
