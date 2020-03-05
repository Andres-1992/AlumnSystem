using BusinessEntities.Enums;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Media;


namespace GUI_WPF.Views
{
    /// <summary>
    /// Interaction logic for RegisterAlumnView.xaml
    /// </summary>
    public partial class RegisterAlumnView : Window
    {
        public RegisterAlumnView()
        {
            InitializeComponent();
            EducationComboBox.ItemsSource = Enum.GetValues(typeof(Education));
            CompetenceLevelComboBox.ItemsSource = Enum.GetValues(typeof(CompetenceLevel));
                  

        }

     
        private void GDPRcheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            AddAlumn.IsEnabled = false;
        }

        private void GDPRcheckBox_Checked(object sender, RoutedEventArgs e)
        {
            AddAlumn.IsEnabled = true;
            MessageBox.Show("Hello");

        }
    }
}
