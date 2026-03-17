using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Strings.YourTHINKINGWork
{
    public class MinimumWindow
    {
        /*
        REFERRED APPROACH:
        This hard problem is a mix of 2 techniques:
        1. Sliding window pattern
        2. Two pointer approach
        */

        /*
        Any Optimization question while thinking through?/Any already learnt pattern you can remember?
        - sliding window pattern of movement
        */

        /*
        Time Complexity: O(n)
        Space Complexity: O(1)
        */
        public string MinimumWindowSubstring(string s, string t)
        {
            int[] mapS = new int[256];
            int[] mapT = new int[256];
            
            foreach(char ch in t)
            {
                mapT[ch]++;
            }

            int left = 0, right = 0, minLen = int.MaxValue, minStart = 0;

            for(; right < s.Length; right++)
            {
                mapS[s[right]]++;

                while(ContainsCheck(mapS,mapT))
                {
                    if(right - left + 1 < minLen)
                    {
                        minLen = right - left + 1;
                        minStart = left;
                    }
                    mapS[s[left]]--;
                    left++;
                } 
            }
            
            return minLen == int.MaxValue ? "" : s.Substring(minStart, minLen);

        }

        private bool ContainsCheck(int[] mapS, int[] mapT)
        {
            for(int i = 0; i < 256; i++)
            {
                if(mapT[i] > mapS[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

 // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY?(Sliding window part was right, but lost direction)
         MY APPROACH (THINK/CODE):
        1. Declare 2 variables i and j and start with pointing to 0th index in string s
        2. Now start incrementing j, till you find a element in string t. 
        3. keep incrementing j, until you find all the elements in t
        4. To keep track of the elements removed in t, store in a queue and keep removing until it is empty
        5. Save the length of the pattern in string s
        6. We need to do this process until end of string s. 
        7. Figure out how to move i along with j to find out the length of the substring found and also
           keep saving the length
        8. May be save the substring along with its value in a Dictionary<string,int>
        9. Pick the minimum value from the Dictionary and the key wrt that particular minimum value needs to be 
        returned.
       
        */ 
        /* CODE:
         public string MinimumWindowSubstring(string s, string t)
        {
            int i = 0, j = 0;
            List<char> myInput = s.ToList();
            List<char> patternSearch = t.ToList();

            Dictionary<string,int> storage = new Dictionary<string, int>();

            for(int x = 0; x < myInput.Count; x++)
            {
                for(int y = 0; y < patternSearch.Count; y++)
                {
                    if(patternSearch[y] == myInput[x])
                    {
                        x++;
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return null;
        }

        */