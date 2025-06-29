public class TYS1_1_BinarySearch
{
    public void BinarySearch(int[] input, int key)
    {
        int size = input.Length;
        int low = 0, high = size - 1;

        while (low < high)
        {
            int mid = (low + high) / 2;

            if (key == input[mid])
            {
                Console.WriteLine("Element found at: " + mid);
                break;
            }
            else if (key < input[mid])
            {
                high = mid - 1;
            }
            else if (key > input[mid])
            {
                low = mid + 1;
            }
            else
            {
                Console.WriteLine("Key not found");
            }
        }

    }
}