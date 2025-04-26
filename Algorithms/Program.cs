using System;

class Program
{
    static void Main(string[] args)
    {
        Algo1_LinearSearchImpl lsi = new Algo1_LinearSearchImpl();
        int[] check = {15,5,20,35,2,42,67,17};

        lsi.LinearSearch(check,11);
    }
}