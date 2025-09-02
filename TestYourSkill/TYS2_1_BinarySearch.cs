public class TYS2_1_BinarySearch
{
    public bool BinarySearch(int[] test, int searchItem, int size)
    {
        Console.WriteLine("Entered the binary search method");
        int low = 0, high = size - 1;

        while (low > high)
        {
            int mid = (low + high) / 2;

            if (searchItem < test[mid])
            {
                high = mid - 1;
            }
            else if (searchItem > test[mid])
            {
                low = mid + 1;
            }
            else
            {
                Console.WriteLine("Item found, it is the element at index: " + mid);
                return true;
            }
        }
        return false;
    }
}