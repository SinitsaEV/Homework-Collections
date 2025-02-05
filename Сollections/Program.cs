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

            List<string> result = MergeUniqueElements(array1, array2);
            ShowListElements(result);
        }

        private static List<string> MergeUniqueElements(string[] array1, string[] array2)
        {
            List<string> uniqueElements = new List<string>();

            foreach (string element in array1)
            {
                if(!uniqueElements.Contains(element))
                {
                    uniqueElements.Add(element);
                }
            }

            foreach (string element in array2)
            {
                if (!uniqueElements.Contains(element))
                {
                    uniqueElements.Add(element);
                }
            }

            return uniqueElements;
        }

        private static void ShowListElements(List<string> list)
        {
            foreach (string s in list)
            {
                Console.Write(s + " ");
            }
        }        
    }
}