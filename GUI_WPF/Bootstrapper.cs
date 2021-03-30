using Caliburn.Micro;
using GUI_WPF.ViewModels;
using System.Windows;

namespace GUI_WPF
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<LogInViewModel>();
        }

    }
}
