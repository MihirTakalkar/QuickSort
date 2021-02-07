using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class Hoare<T> where T : IComparable
    {
        public void Partition(List<T> list)
        {
            Sort(list, 0, list.Count - 1);
        }

        public void Sort(List<T> list, int start, int end)
        {
            if ((end - start) < 1)
            {
                return;
            }

            T pivot = list[start];
            int left = start - 1;
            int right = end + 1;

            while (true)
            {
                do
                {
                    left++;
                } while (list[left].CompareTo(pivot) < 0);

                do
                {
                    right--;
                } while (list[right].CompareTo(pivot) > 0);

                if(left >= right)
                {
                    break;
                }

                T temp = list[left];
                list[left] = list[right];
                list[right] = temp;
            }

            //sort left subarray
            Sort(list, start, right);

            //sort right subarray
            Sort(list, right + 1, end);

        }
    }
}
