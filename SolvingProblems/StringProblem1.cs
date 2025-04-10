/*

1. Reverse a String / Reverse Words in a String
Problem 1: Reverse the entire string.

Problem 2: Reverse the order of words in a sentence.

*/

using System;
using System.Collections.Generic;

public class StringProblem1
{
    public void Reverse(string input)
    {
        List<char> store = new List<char>();

        for(int i = input.Length - 1; i >= 0 ; i--)
        {
            store.Add(input[i]);
        } 
        string combinedString = string.Join("", store); // within the "" whatever character you add say like , or * it will separate the sting with those char, if you leave blank it will print the joint answer
        Console.WriteLine("Reversed string is: " +combinedString);
        
    }
}

/*
 StringProblem1 sp1 = new StringProblem1();
      sp1.Reverse("Abhishek");
*/