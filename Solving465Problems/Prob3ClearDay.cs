using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Prob3ClearDay
    {
        public int ClearDays(int rainyDays, int cloudyDays)
        {
            int clearDaysCount = 0;
            if(rainyDays + cloudyDays != 7)
            {
                clearDaysCount = 7 - (rainyDays + cloudyDays);
            }
            return clearDaysCount;
        }
    }

      /*  Prob3ClearDay p3 = new Prob3ClearDay();
        Console.WriteLine("Input the rainy days count & cloudy days count: ");
        string input = Console.ReadLine();
        string[] values = input.Split(' ');
        int rainyDays = int.Parse(values[0]);
        int cloudyDays = int.Parse(values[1]);
        Console.WriteLine(p3.ClearDays(rainyDays, cloudyDays)); */