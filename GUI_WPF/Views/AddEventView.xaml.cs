using GUI_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GUI_WPF.Views 
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        AddEventViewModel vm = new AddEventViewModel();
        public Window1()
        {
            InitializeComponent();
            DataContext = vm;
            start.DisplayDateStart = DateTime.Now;
        }

        private void AddEvent(object sender, RoutedEventArgs e)
        {
            vm.AddEvent();
            
        }

        private void DeleteEvent(object sender, RoutedEventArgs e)
        {
            vm.DeleteEvent(Events.SelectedItem);
        }
    }
}
