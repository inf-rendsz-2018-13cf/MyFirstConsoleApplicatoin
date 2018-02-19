using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!\n" + GetUserName());
        }

        public static string GetUserName()
        {
            return "Nandor Dudas";
        }
    }
}
