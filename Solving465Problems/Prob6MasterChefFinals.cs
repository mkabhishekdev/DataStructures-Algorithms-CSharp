using System;
using System.Runtime.InteropServices;

public class Prob6MasterChefFinals
{
    public string MasterChefFinals(int chefRank)
    {
        if(chefRank <= 10)
        {
            return "YES";
        }
        return "NO";
    }
}


/*
  Prob6MasterChefFinals p6 = new Prob6MasterChefFinals();
        Console.WriteLine("Enter the number of testcases: ");
        int input = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < input; i++)
        {
            Console.WriteLine("enter rank to check: ");
            int checkRankValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p6.MasterChefFinals(checkRankValue));
        }
*/