using System;

namespace ConsoleApp.Modules
{
    public static class InputModule
    {
        public static string ReadString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}