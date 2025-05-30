public class Algo3_BubbleSortImpl
{

    public void BubbleSort(int[] input, int n)
    {
        int temp;
        int flag;

        for (int i = 0; i < n - 1; i++)
        {
            flag = 0;
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (input[j] > input[j + 1])
                {
                    temp = input[j];
                    input[j] = input[j + 1];
                    input[j + 1] = temp;
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("It is already a sorted array");
                break;
            }
        }
    }

}

/*
   Algo3_BubbleSortImpl bs = new Algo3_BubbleSortImpl();
        int[] sampleData = { 1,2,3,4,5 };

        bs.BubbleSort(sampleData, 5);

        Console.WriteLine("The resultant array after sorting is: ");

        for (int i = 0; i < sampleData.Length; i++)
        {
            Console.WriteLine(sampleData[i]);
        }
*/