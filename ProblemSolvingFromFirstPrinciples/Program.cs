class Program
{
    static void Main(string[] args)
    {
        LongestIncSubseq lis = new LongestIncSubseq();
        int[] input = {10,9,2,5,3,7,101,18};

        Console.WriteLine(lis.LongestIncSubseqImpl(input));
    }
}
