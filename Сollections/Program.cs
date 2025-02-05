using System;
using System.Collections.Generic;
using System.Text;

namespace Сollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string AddCommand = "0";
            const string RemoveCommand = "1";
            const string ShowCommand = "2";
            const string ExitCommand = "3";

            Dictionary<string, List<string>> personnelAccounting = new Dictionary<string, List<string>>
            {
                {"курьер",new List<string>{"Наркевич Владимир Николаевич"} },
                {"слесарь",new List<string>{"Бурван Илья Викторович","Барауля Андрей Дмитриевич" } },
                {"химик",new List<string>{ "Дудук Яна Игоревна"} },

            };
            
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            bool isActive = true;

            while (isActive)
            {
                Console.WriteLine($"{AddCommand} - добавить\n{RemoveCommand} - удалить\n{ShowCommand} - показать всех\n{ExitCommand} - выход");

                string post;
                string fullName;
                string playerInput = Console.ReadLine();

                switch (playerInput)
                {
                    case AddCommand:
                        GetEmployeeData(out post, out fullName);
                        AddEmployee(personnelAccounting, post, fullName);
                        break;

                    case RemoveCommand:
                        GetEmployeeData(out post, out fullName);
                        RemoveEmployee(personnelAccounting, post, fullName);
                        RemoveEmptyPosts(personnelAccounting);
                        break;

                    case ShowCommand:
                        ShowStaffInformation(personnelAccounting);
                        break;

                    case ExitCommand:
                        Console.WriteLine("Вы вышли из программы.");
                        isActive = false;
                        break;

                    default:
                        Console.WriteLine("Неверный ввод.");
                        break;
                }
            }
        }

        private static void AddEmployee(Dictionary<string, List<string>> staff, string post, string fullName)
        {
            if (staff.TryGetValue(post, out List<string> staf))
                staf.Add(fullName);
            else
                staff.Add(post, new List<string> { fullName });
        }

        private static void RemoveEmployee(Dictionary<string, List<string>> staff, string post, string fullName)
        {
            if (staff.ContainsKey(post))
                if (staff[post].Contains(fullName))
                    staff[post].Remove(fullName);
        }

        private static void RemoveEmptyPosts(Dictionary<string, List<string>> staff)
        {
            List<string> removePosts = GetEmptyPosts(staff);

            RemovePosts(removePosts,staff);            
        }

        private static List<string> GetEmptyPosts(Dictionary<string, List<string>> staff)
        {
            List<string> removePosts = new List<string>();

            foreach (string post in staff.Keys)
            {
                if (staff[post].Count > 0)
                    continue;

                removePosts.Add(post);
            }

            return removePosts;
        }

        private static void ShowStaffInformation(Dictionary<string, List<string>> staff)
        {
            foreach (string post in staff.Keys)
            {
                Console.WriteLine($"Должность : {post}");

                foreach(string person in staff[post])
                {
                    Console.WriteLine($" - {person}");
                }
            }
        }

        private static void RemovePosts(List<string> removePosts, Dictionary<string, List<string>> staff)
        {
            foreach(string post in removePosts)
                staff.Remove(post);
        }

        private static void GetEmployeeData(out string post,out string fullName)
        {
            Console.Write("Введите должность работника:");
            post = Console.ReadLine().ToLower();
            Console.Write("Введите ФИО работника:");
            fullName = Console.ReadLine();
        }
    }
}
