using System;
using System.Collections.Generic;
using System.Text;

namespace Сollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ExitCommand = "exit";
            const string SumCommand = "sum";

            List<int> numbers = new List<int>();

            bool isRunning = true;

            Console.OutputEncoding = Encoding.Unicode;

            ShowMenu(ExitCommand, SumCommand);

            while (isRunning)
            {
                string playerInput = Console.ReadLine();

                switch (playerInput)
                {
                    case ExitCommand:
                        isRunning = false;
                        Console.WriteLine("Вы вышли из программы.");
                        break;

                    case SumCommand:
                        GetSum(numbers);
                        break;

                    default:
                        TryAddNumber(playerInput, numbers);
                        break;
                }
            }
        }

        private static int GetSum(List<int> numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
                sum += number;

            Console.WriteLine("Сумма всех чисел: " + sum);
            return sum;
        }

        private static void ShowMenu(string exitCommand, string sumCommand)
        {
            Console.WriteLine("Команды программы:");
            Console.WriteLine($"Выйти из программы - {exitCommand}\nВывести сумму всех чисел - {sumCommand}\nВведите любое число для добавления.");
        }

        private static void TryAddNumber(string playerInput, List<int> numbers)
        {
            if (int.TryParse(playerInput, out int playerNumber))
            {
                numbers.Add(playerNumber);
                Console.WriteLine($"Добавлено число: {playerInput}");
            }
            else
            {
                Console.WriteLine("Неверный ввод");
            }
        }
    }
}

//В массивах вы выполняли задание "Динамический массив"

//Используя всё изученное, напишите улучшенную версию динамического массива(не обязательно брать своё старое решение)

//Задание нужно, чтобы вы освоились с List и прощупали его преимущество. 

//Проверка на ввод числа обязательна.

//Пользователь вводит числа, и программа их запоминает. 

//Как только пользователь введёт команду sum, программа выведет сумму всех введенных чисел. 

//Выход из программы должен происходить только в том случае, если пользователь введет команду exit.