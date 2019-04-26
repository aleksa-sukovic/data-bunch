using System;
using System.Threading;

namespace DataBunch.foundation.utils
{
    public class ExceptionHandler
    {
        public static void handle(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(((Exception) e.ExceptionObject).Message);
        }

        public static void handleThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Console.WriteLine(e.Exception.Message);
        }
    }
}
