using System;
using System.Collections.Generic;
using System.Text;

namespace Сollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                {"авария","Повреждение, выход из строя какого-н. механизма, машины, устройства во время работы, движения."},
                {"август","Восьмой месяц календарного года."},
                {"автобиография","Описание своей жизни."},
                {"бактерия","Микроорганизм, преимущ. одноклеточный."},
                {"баланс","Сравнительный итог прихода и расхода"},
                {"казан","Котёл для приготовления пищи."},
                {"кабинет","Комната для занятий, работы."},
                {"казнь","Лишение жизни как высшая карающая мера."}
            };

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            bool isActive = true;
            string exitCommand = "exit";
            string errorMessage = "Неверный ввод или такого слова нет в словаре.";

            while (isActive)
            {
                Console.WriteLine($"\nВведите слово и узнайте его значение.\nВведите {exitCommand} для выходы.");
                string playerInput = Console.ReadLine();
                Console.Clear();

                if (playerInput == exitCommand)
                {
                    isActive = false;
                }
                else
                {
                    Console.WriteLine(playerInput.ToUpper());
                    Console.WriteLine(GetDescription(dictionary, playerInput, errorMessage));
                }
            }
        }

        private static string GetDescription(Dictionary<string, string> dictionary, string word, string errorMessage)
        {
            if (dictionary.ContainsKey(word.ToLower()))
                return dictionary[word.ToLower()]; 
            else            
                return errorMessage;                     
        }
    }
}
