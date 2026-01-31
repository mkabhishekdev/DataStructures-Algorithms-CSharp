using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;

    /*
    REFERRED APPROACH



    */

    /*
    Time Complexity:
    Space Complexity:
    */

public class CharacterReplacementImpl
{
    public int CharacterReplacementImpl(string s, int k)
    {

    }
}





// If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
/* FAILED APPROACH & WHY(Need to use 'Sliding Window' technique)
 APPROACH I CAME UP WITH::
     1. Write condition within while (count <= k) with count starting with 1 to maintain the number of times conditions 
     within run
     2. Use a Dictionary to store the 'character' in the input string as key and the 'count of character' in the string 
     as value
     3. Pick the key with the highest count value. Try to check if a substring exists with the length equal to the count,
     if not replace the character within the substring which does not match the character with the high count in the
     substring.
 public int CharacterReplacement(string s, int k)
        {
            Dictionary<char, int> store = new Dictionary<char, int>();

            int size = 1;

            while(size <= k)
            {
                //store char and count in a dictionary
                foreach (char c in s)
                {
                    if (store.ContainsKey(c))
                    {
                        store[c]++;
                    }
                    else
                    {
                        store[c] = 1;
                    }
                }

               // get the highest char with its count
                var highest = store.OrderByDescending(x => x.Value).First();
                char maxChar = highest.Key;
                int maxCount = highest.Value;

                //want to do the step 3 mentioned in my approach

                size++;
            }
        }
*/