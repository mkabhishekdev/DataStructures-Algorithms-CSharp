using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Algo6_QuickSort_AbdulSir
    {
        public int[] QuickSort(int[] input)
        {
            QuickSortImpl(input, 0, input.Length - 1);
            return input;
        }

        private void QuickSortImpl(int[] input, int low, int high)
        {
            if (low < high)
            {
                int j = Partition(input, low, high);
                QuickSortImpl(input, low, j);
                QuickSortImpl(input, j + 1, high);
            }
        }

        public int Partition(int[] input, int low, int high)
        {
            int pivot = input[low];
            int i = low;
            int j = high + 1;

            while (i < j)
            {
                do
                {
                    i++;
                } while (i <= high && input[i] <= pivot);

                do
                {
                    j--;
                } while (input[j] > pivot);

                if (i < j)
                {
                    Swap(input, i, j);
                }
            }
            Swap(input, low, j);
            return j;
        }

        public void Swap(int[] input, int x, int y)
        {
            int temp = input[x];
            input[x] = input[y];
            input[y] = temp;
        }

    }
}


/*
Algo6_QuickSort_AbdulSir alg6 = new Algo6_QuickSort_AbdulSir();
        int[] test = { 8, 3, 6, 1, 4, 5, 2 };

        int[] result = alg6.QuickSort(test);

        Console.WriteLine("The sorted array is: ");
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
*/