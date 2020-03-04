using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using System.Windows;
using GUI_WPF.ViewModels;

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
            DisplayRootViewFor<AddEventViewModel>();
        }
    }
}
