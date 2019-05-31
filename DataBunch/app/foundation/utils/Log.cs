using System;

namespace DataBunch.app.foundation.utils
{
    public static class Log
    {
        public static void info(string message)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("[INFO]");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" " + message);

            Console.ResetColor();
        }

        public static void success(string message)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("[SUCCESS]");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" " + message);

            Console.ResetColor();
        }

        public static void error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("[FAILURE]");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" " + message);

            Console.ResetColor();
        }

        public static void debug(string message)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("[DEBUG]");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" " + message);

            Console.ResetColor();
        }
    }
}
