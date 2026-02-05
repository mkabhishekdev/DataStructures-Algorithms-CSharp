using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

/*
APPROACH I CAME UP WITH::
1. Create a List<Character> type to store each char from the input string
2. Start adding char to the list, compare if a character exist, If not add
3. If yes, stop
     - calculate the length of the list, save that value in a variable say 'lastSavedlength'
     - empty the list
4. Continue adding to the list from where you stopped last, keep doing the same above
5. The maximum substring length store it in the lastSavedLength variable
6. Return the lastSavedLength 

Above Almost Correct:
But you have to use DuplicateIndex and RemoveRange in the else condition instead of deleting everything in else

Time Complexity: O(n2) Why? - The store list below groes on large inputs, each contains check will become more expensive
Space Complexity: O(n)
*/

namespace ProductCodingPractice.Strings.YourTHINKINGWork
{
    public class LongestSubstring
    {

        public int LengthOfLongestSubstring(string s)
        {
            if (s == null || s == "")
            {
                return 0;
            }
            if(s.Length == 1)
            {
                return 1;
            }

            List<Char> store = new List<char>();
            store.Add(s[0]);

            int lastSavedLength = 0;


            for (int i = 1; i < s.Length; i++)
            {
                if (!store.Contains(s[i]))
                {
                    store.Add(s[i]);
             
                }
                else
                {
                    if (store.Count > lastSavedLength)
                    {
                        lastSavedLength = store.Count;
                    }
                    //get the duplicate index 
                    int duplicateIndex = store.IndexOf(s[i]);
                    store.RemoveRange(0, duplicateIndex + 1); 
                    store.Add(s[i]);
                }
            }

            return Math.Max(lastSavedLength, store.Count);

        }

    }

}


// If all test cases not clearing, PRACTICE DEBUGGING
/* FAILED APPROACH & WHY

      */ 