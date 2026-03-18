class Program
{
    static void Main(string[] args)
    {
        FindMin fm = new FindMin();
        int[] input = {2,1};

        Console.WriteLine(fm.FindMinImpl(input));
    }
}
