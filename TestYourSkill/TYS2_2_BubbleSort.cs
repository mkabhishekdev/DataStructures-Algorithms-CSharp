public class TYS2_2_BubbleSort
{
    public void BubbleSortImpl(int[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j < input.Length - 1; j++)
            {
                int temp;
                if (input[i] > input[j])
                {
                    temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                }
                
            }
        }
    }
}