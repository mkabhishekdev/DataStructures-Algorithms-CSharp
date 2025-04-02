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
