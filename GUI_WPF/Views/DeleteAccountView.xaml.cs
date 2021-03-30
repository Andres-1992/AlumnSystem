using System.Windows;

namespace GUI_WPF.Views
{
    /// <summary>
    /// Interaction logic for DeleteAccountView.xaml
    /// </summary>
    public partial class DeleteAccountView : Window,IPasswordProvider
    {
        public DeleteAccountView()
        {
            InitializeComponent();
        }

        public string Password => PwBox.Password;
    }
}
