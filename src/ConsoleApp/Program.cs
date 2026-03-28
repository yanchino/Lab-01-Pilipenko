using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для подсчета русских гласных:");
            string input = Console.ReadLine();

            
            string vowels = "аеёиоуыэюя";
            int count = 0;

            if (!string.IsNullOrEmpty(input))
            {
                
                string lowerInput = input.ToLower();

                foreach (char c in lowerInput)
                {
                    if (vowels.Contains(c))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Количество гласных букв: {count}");
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}