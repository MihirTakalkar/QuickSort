using System;
using System.Collections.Generic;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>{ 7, 4, 3, 6, 2, 1, 5 };
            List<int> list = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            { 
                list.Add(rand.Next(1, 1000));
            }

            RecursiveSort<int> sort = new RecursiveSort<int>();
            
            sort.Partition(list);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
