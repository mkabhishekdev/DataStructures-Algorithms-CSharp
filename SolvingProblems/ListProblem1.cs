/*

1. Remove Duplicates from a List
Problem:
Given a list of integers, remove all duplicates without using LINQ or Distinct().

Input:
List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 3, 5 };

Expected Output:
1 2 3 4 5

*/
using System;
using System.Collections.Generic;

public class ListProblem1
{
    public List<int> RemoveDuplicates(List<int> input)
    {
        List<int> storage = new List<int>();
 

        for(int i = 0; i < input.Count; i++)
        {
            for(int j = i+1; j < input.Count; j++)
            {
                if(input[i] == input[j])
                {
                    input.Remove(input[j]);
                }
            }
            
        }

        return input;
    }

}

/*
 ListProblem1 lp1 = new ListProblem1();
        List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 3, 5 };
        List<int> result = lp1.RemoveDuplicates(numbers);

        Console.WriteLine("Elements in the list after removal: ");
        for(int i = 0; i < result.Count; i++)
        {
            Console.WriteLine("" + result[i]);
        }
*/