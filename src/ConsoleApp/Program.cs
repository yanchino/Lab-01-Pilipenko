using System;
using ConsoleApp.Modules;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Ввод
            string userInput = InputModule.ReadString("Введите строку на русском языке:");

            // 2. Валидация
            if (ValidationModule.IsNotEmpty(userInput))
            {
                // 3. Обработка и вывод
                ProcessingModule.CountAndPrintVowels(userInput);
            }
            else
            {
                Console.WriteLine("Ошибка: строка не должна быть пустой!");
            }
        }
    }
}