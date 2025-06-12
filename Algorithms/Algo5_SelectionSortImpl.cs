public class Algo5_SelectionSortImpl
{
    public void SelectionSort(int[] input, int size)
    {
        for (int i = 0; i < size - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < size; j++)
            {
                if (input[j] < input[min])
                {
                    min = j;
                }
            }
            if (min != i)
            {
                int temp;
                temp = input[i];
                input[i] = input[min];
                input[min] = temp;
            }
        }
        Console.WriteLine("Array after Selection Sort process is: ");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(input[i]);
        }
    }

}

// Time-Complexity:
 //  Worst case: O(n2), Best case: O(n2)

/*
   Algo5_SelectionSortImpl selectionSort = new Algo5_SelectionSortImpl();
        int[] test = { 7, 4, 10, 8, 3, 1 };

        selectionSort.SelectionSort(test, 6);
*/