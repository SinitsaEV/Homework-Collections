using System;
using System.Collections.Generic;

namespace Сollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "1", "2", "3", "1" };
            string[] array2 = { "1", "4", "5" };

            List<string> result = new List<string>();
            AddUniqueElements(result,array1);
            AddeUniqueElements(result, array2);
            ShowListElements(result);
        }

        private static void AddUniqueElements(List<string> uniqueElements, string[] array)
        {
            foreach (string element in array)
            {
                if (uniqueElements.Contains(element) == false)
                {
                    uniqueElements.Add(element);
                }
            }

            return uniqueElements;
        }

        private static void ShowListElements(List<string> list)
        {
            foreach (string element in list)
            {
                Console.Write(element + " ");
            }
        }        
    }
}
