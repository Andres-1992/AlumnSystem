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
            MessageBox.Show("Genom att kryssa i rutan samtycker du till att Högskolan i Borås," +
                    " behandlar personuppgifter om dig, i enlighet med vår integritetspolicy. Vi använder uppgifter om dig för att kunna nå dig med information," +
                    " erbjudanden och relevant innehåll. Du kan närsomhelst avregistrera dig från dessa.");

            AddAlumn.IsEnabled = true;
        }

        private void GDPRcheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            AddAlumn.IsEnabled = false;
        }
    }
}
