using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Strings.YourTHINKINGWork
{
    /* My approach
    1. in the program.cs I will write the user input related code to send the two inputs to the 
       anagram check method
    2. in the anagram check, will keep a dictionary<char,int> to store each char in the string as key
       and the count as the value
    3. will check if that count matches with the toCheck string
    4. if matches will return true or will return false
    */

    /* any optimization

    */

    /* 
    time complexity: O(n)
    space complexity: O(n)
    */

    /*
    Write a program where you check two inputs you would receive from the user and 
    check if they are anagrams or not and return true/false result 
    */
    public class AnagramCheckWithUserInputs
    {
        //"cinema":"iceman" | "listen":"silent" | "earth":"heart"
        public bool AnagramCheck(string s, string toCheck)
        {
            if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(toCheck))
            {
                return false;
            }

            if(s.Length != toCheck.Length)
            {
                return false;
            }

            Dictionary<char, int> charCounter = new Dictionary<char, int>();

            foreach(char c in s)
            {
                if(!charCounter.ContainsKey(c))
                {
                    charCounter[c] = 1;
                }
                else
                {
                    charCounter[c]++;
                }
            }

            foreach(char ch in toCheck)
            {
                if(!charCounter.ContainsKey(ch))
                {
                    return false;
                }

                charCounter[ch]--;

                if(charCounter[ch] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

/*
   Anagram ang = new Anagram();

        Console.WriteLine("Enter the first input string: ");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second input string: ");
        string input2 = Console.ReadLine();

        Console.WriteLine("If true, the two input strings are anagrams. If false, they are not: "+ang.AnagramCheck(input1,input2));
*/