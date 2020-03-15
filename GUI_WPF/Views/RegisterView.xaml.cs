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
    /// Interaction logic for RegisterView.xaml
    /// </summary>
    public partial class RegisterView : Window
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void GDPRcheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("yani du godkänner alltind som gdpr innebär");
            AddAlumn.IsEnabled = true;

        }

        private void GDPRcheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            AddAlumn.IsEnabled = false;

        }
    }
}
