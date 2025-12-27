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

//  Time complexity: Best case =  O(n), Worst case = O(n2) 
                //    Space complexity: O(1) [when space usage is just 'Constant']

/*
  Algo4_InsertionSortImpl a4 = new Algo4_InsertionSortImpl();
        int[] test = { 8, 3, 11, 1, 7, 5, 2 };

        a4.InsertionSort(test, 7);
*/