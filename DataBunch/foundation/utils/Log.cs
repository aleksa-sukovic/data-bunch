using System;

namespace DataBunch.foundation.utils
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
    }
}
