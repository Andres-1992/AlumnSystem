using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using System.Windows;
using GUI_WPF.ViewModels;
using DataLayer.Contexts;
using DataLayer;
using BusinessLayer;

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
