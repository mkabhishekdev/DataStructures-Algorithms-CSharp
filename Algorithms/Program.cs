using System;

class Program
{
    static void Main(string[] args)
    {
        Algo2_BinarySearchIterativeMethod bsi = new Algo2_BinarySearchIterativeMethod();
        int[] values = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16};
        bsi.BinarySearch(values,3);
    }
}