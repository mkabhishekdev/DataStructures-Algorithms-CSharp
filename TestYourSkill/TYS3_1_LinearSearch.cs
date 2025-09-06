public class TYS3_1_LinearSearch
{
    public int LinearSearchImpl(int[] check, int searchValue)
    {
        int size = check.Length;

        if (size == 0)
        {
            return -1;
        }
        for (int i = 0; i < size; i++)
        {
            if (check[i] == searchValue)
            {
                Console.WriteLine("Value found in the input at index: " + i);
                return -1;
            }
        }
        Console.WriteLine("Value not found in the input array");
        return -1;
    }
}