using System;
using System.Collections.Generic;
using System.Text;

namespace Сollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int shopBalanse = 0;
            int shopBalansePosX = 50;
            int shopBalansePosY = 0;

            Queue<int> clients = new Queue<int>(new int[] { 1, 43, 5, 1, 8, 1, 9 });

            Console.OutputEncoding = Encoding.Unicode;

            while (clients.Count > 0)
            {
                Console.WriteLine("Клиент пришел");
                MakePurchase(ref shopBalanse, clients.Dequeue());
                Console.WriteLine("Клиент ушел");
                ShowBalanse(shopBalansePosX, shopBalansePosY, shopBalanse);

                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void MakePurchase(ref int shopBalanse,int cost)
        {
            Console.WriteLine($"Клиент потратил {cost} $");
            shopBalanse += cost;
        }

        private static void ShowBalanse(int posX, int posY, int balanse)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write($"БАЛАНС магазина: {balanse}");
        }
    }
}