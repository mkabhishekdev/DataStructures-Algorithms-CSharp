class Program
{
    static void Main(string[] args)
    {
        int[][] input =
        {
            new int[] {0,1,2,0},
            new int[] {3,4,5,2},
            new int[] {1,3,1,5}  
        };

        SetZeroes sz = new SetZeroes();
        sz.SetZeroesImpl(input);
    }
}
