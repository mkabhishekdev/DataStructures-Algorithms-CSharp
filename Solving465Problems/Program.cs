using System;

class Program
{
    static void Main(string[] args)
    {
        Prob3ClearDay p3 = new Prob3ClearDay();
        Console.WriteLine("Input the rainy days count & cloudy days count: ");
        string input = Console.ReadLine();
        string[] values = input.Split(' ');
        int rainyDays = int.Parse(values[0]);
        int cloudyDays = int.Parse(values[1]);
        Console.WriteLine(p3.ClearDays(rainyDays, cloudyDays));

    }
}