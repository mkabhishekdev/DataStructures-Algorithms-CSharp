class Program
{
    static void Main(string[] args)
    {
      
        JumpGameSetTwo jg = new JumpGameSetTwo();
        int[] input = {3,2,1,0,4};

        Console.WriteLine(jg.JumpGameImpl(input));
    
    }
}
