using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Strings.YourTHINKINGWork
{
    /* My Approach
    1. will take 2 pointers, i and j
    2. i will start from the 0th index of s and j will start from last index of s
    3. within a while(i < j) will keep doing i++,j-- when s[i] = s[j]
    4. any value where s[i] = s[j], will return boolean match false immediately
    5. if it reaches the end, yeah its boolean
    */

    /* any optimization

    */

    /*
    time complexity: O(n)
    space complexity: O(1)
    */
    public class Palindrome
    {
        // "racecar", "malayalam", "macbook"
        public bool PalindromeCheck(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return false;
            }

            int i = 0;
            int j = s.Length - 1;

            while(i < j)
            {
                if(s[i].Equals(s[j]))
                {
                    i++;
                    j--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }       
    }
}