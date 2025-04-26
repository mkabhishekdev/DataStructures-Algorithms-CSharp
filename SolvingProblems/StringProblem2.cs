/*

2. Check if String is Palindrome
Variant 1: Case insensitive, ignore non-alphanumeric.

Variant 2: Simple string palindrome.

Why?
Very common for interviews to check two-pointer logic and clean string handling in C#.

A palindrome is a word, sentence, verse, or even number that reads the same backward or forward.
Examples are civic, radar, level, rotor, kayak, madam, and refer. The longest common ones are rotator, deified, 
racecar, and reviver; longer examples such as redivider, kinnikinnik, and tattarrattat are orders of magnitude rarer.
*/
using System.Text;
using System.Collections.Generic;

public class StringProblem2
{
    public string CheckPalindrome(string inputString)
    {
        StringBuilder sb = new StringBuilder(inputString);
        string reversedInput = "", result = "";

        for(int i = sb.Length-1; i >= 0; i--)
        {
            reversedInput += sb[i].ToString();
        }
        
        if(reversedInput.Equals(inputString))
        {
            result = "The input string is a palindrome";
        }
        else
        {
            result = "The input string is not a palindrome";
        }

        return result;

    }
}


/*
   StringProblem2 sp2 = new StringProblem2();
        Console.WriteLine(sp2.CheckPalindrome("kinnikinnik"));

*/