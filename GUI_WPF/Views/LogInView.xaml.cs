using System.Windows;

namespace GUI_WPF.Views
{
    /// <summary>
    /// Interaction logic for LogInView.xaml
    /// </summary>
    public partial class LogInView : Window,IPasswordProvider
    {
        public LogInView()
        {
            InitializeComponent();
        }

        public string Password => PwBox.Password;
    }
}
