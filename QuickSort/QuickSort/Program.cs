using System;
using System.Collections.Generic;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>{ 7, 4, 3, 6, 7, 2, 1, 7, 5 };
           //List<int> list = new List<int>();
            Random rand = new Random();
            
            Hoare<int> sort = new Hoare<int>();
            sort.Partition(list);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
