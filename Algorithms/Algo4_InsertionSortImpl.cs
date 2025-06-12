public class Algo4_InsertionSortImpl
{

    public void InsertionSort(int[] input, int size)
    {
        for (int i = 1; i < size; i++)
        {
            int temp = input[i];
            int j = i - 1;

            while (j >= 0 && input[j] > temp)
            {
                input[j + 1] = input[j];
                j--;
            }
            input[j + 1] = temp;
        }

        Console.WriteLine("Array after Insertion sort process is: ");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(input[i]);
        }
    }

}

// Time Complexity: Worst Case: O(n2) ,Best Case: O(n)

/*
  Algo4_InsertionSortImpl a4 = new Algo4_InsertionSortImpl();
        int[] test = { 8, 3, 11, 1, 7, 5, 2 };

        a4.InsertionSort(test, 7);
*/