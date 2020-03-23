using System.Windows;

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
