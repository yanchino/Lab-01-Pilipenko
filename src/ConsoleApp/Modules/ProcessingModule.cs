using System;
using System.Linq;

namespace ConsoleApp.Modules
{
    public static class ProcessingModule
    {
        public static void CountAndPrintVowels(string input)
        {
            string vowels = "аеёиоуыэюя";
            int count = input.ToLower().Count(c => vowels.Contains(c));

            Console.WriteLine($"Количество гласных букв: {count}");
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}