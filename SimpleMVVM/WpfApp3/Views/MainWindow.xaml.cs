using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp3.ViewModels;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel vm = new MainWindowViewModel();
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void AddCarToCollection(object sender, RoutedEventArgs e)
        {
            vm.AddCarToCollection();
        }

        private void SavePerson(object sender, RoutedEventArgs e)
        {
            vm.SavePerson();
        }

        private void DeletePerson(object sender, RoutedEventArgs e)
        {
            vm.DeletePerson(dataGridPeople.SelectedItem);
        }

        private void DeleteCar(object sender, RoutedEventArgs e)
        {
            vm.DeleteCar(dataGridCars.SelectedItem);
        }
    }
}
