using System;
using System.Threading;
using System.Windows.Forms;
using DataBunch.foundation.utils;

namespace DataBunch
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new ThreadExceptionEventHandler(ExceptionHandler.handleThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(ExceptionHandler.handle);

            Application.Run(new ui.forms.WelcomeForm());
        }
    }
}
