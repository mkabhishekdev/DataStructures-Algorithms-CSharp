using System;

public class Prob5TaxSaving
{
    public int TaxSaving(int yourEarning, int abovePayTax)
    {
        return yourEarning - abovePayTax;
    }
}

/*
Prob5TaxSaving p5 = new Prob5TaxSaving();
        Console.WriteLine("Enter the number of testcases: ");
        int testCases = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < testCases; i++)
        {
            Console.WriteLine("Enter X and Y: ");
            string input = Console.ReadLine();
            string[] values = input.Split(' ');
            int yourEarning = int.Parse(values[0]);
            int abovePayTax = int.Parse(values[1]);
            Console.WriteLine(p5.TaxSaving(yourEarning,abovePayTax));
        }
*/