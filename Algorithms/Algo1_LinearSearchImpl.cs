using System;

public class Algo1_LinearSearchImpl
{
    public void LinearSearch(int[] input, int key)
    {
        for(int i = 0; i < input.Length; i++)
        {
            if(input[i] == key)
            {
                Console.WriteLine("Element found at position: " +i);
                return;
            }
        }
        Console.WriteLine("Element not found");

    }
}

/*
Time Complexity:
best case: O(1)
worst case: O(n)
average case: 1+2+3+........+n/n = n(n+1)/2n = n+1/2

Space complexity: O(1) = constant space
Why?
You are not creating any new data structures inside LinearSearch.
You are simply reading the input array, which was already passed to the method.
Other than a few primitive variables (i, key), no extra memory usage grows with the input size n.
*/