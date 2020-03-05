using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Models
{
    public class Car : INotifyPropertyChanged
    {
        private string licenseNumber;
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value;
                Changed();
            }
        }

        public string LicenseNumber
        {
            get { return licenseNumber; }
            set { licenseNumber = value;
                Changed();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        internal void Delete()
        {
            DataManager.CarDelete(this.LicenseNumber);
        }
    }
}
