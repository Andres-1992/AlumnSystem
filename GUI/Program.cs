using BusinessLayer;
using DataLayer;
using DataLayer.Contexts;
using System;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDbContext AppDbContext = new AppDbContext();
            UnitOfWork UnitOfWork = new UnitOfWork(AppDbContext);
            Services Services = new Services(AppDbContext, UnitOfWork);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn(Services));
            //  Application.Run(new DeleteAccount());
        }
    }
}
