using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
    {
        static void main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 20);
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
            int max = arr.Max();
            int min = arr.Min();
            Console.WriteLine("\nМаксимальный элемент массива = {0}", max);
            Console.WriteLine("\nМиниимальный элемент массива = {0}", min);
            int raznost = max - min;
            Console.WriteLine("\nРазность = " + raznost);
            Console.ReadKey();
        }
}