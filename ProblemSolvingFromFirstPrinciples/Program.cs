class Program
{
    static void Main(string[] args)
    {
        BuySellStock bss = new BuySellStock();
        int[] input = {7,1,5,3,6,4};

        Console.WriteLine(bss.BuySell(input));
    
    }
}
