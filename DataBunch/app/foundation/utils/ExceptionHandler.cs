using System;
using System.Threading;
using DataBunch.foundation.exceptions;

namespace DataBunch.foundation.utils
{
    public static class ExceptionHandler
    {
        public static void handle(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is BaseException exception) {
                exception.show();
            }

            Console.WriteLine(e.ExceptionObject);
            Log.error(((Exception) e.ExceptionObject).Message);
        }

        public static void handleThreadException(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception is BaseException exception) {
                exception?.show();
            }

            Console.WriteLine(e.Exception);
            Log.error(e.Exception.Message);
        }
    }
}
