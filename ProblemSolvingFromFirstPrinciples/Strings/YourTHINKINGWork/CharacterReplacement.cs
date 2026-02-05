using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;

    /*
    REFERRED APPROACH
    The below is called 'Sliding window technique',debug the below code. You will clearly get what is it.
    1. The idea starts with you creating a int[] of size 26 specific for alphabet storage
    2. You will have two pointers 'left' and 'right' which will start from 0. And also MaxWindow,MaxFrequency
       variables as well.
    3. You start with a for loop using 'right' which will check till the end of the string
    4. Keep track of the frequency of each alphabet and getting max value & window length
    5. you will have a condition: if(maxlength - maxfrequency) > k. This is the most important step
    6. In this condition only you understand if it is crossing the value of 'k' which shouldn't happen and
       if it does, you move left position by one place and also reducing the frequency of the left most alphabet
       by 1(since you moved one step)
    7. Do the entire procedure until the last character and return the max window
    */

    /*
    Time Complexity: O(n)
    Space Complexity: O(1)
    */

public class CharacterReplacement
{
    public int CharacterReplacementImpl(string s, int k)
    {
        int[] freq = new int[26];
        int left = 0;
        int maxWindow = 0;
        int maxFrequency = 0;

        for (int right = 0; right < s.Length; right++)
        {
            freq[s[right] - 'A']++;
            maxFrequency = Math.Max(maxFrequency, freq[s[right] - 'A']);
            int windowLength = right - left + 1;

            if (windowLength - maxFrequency > k)
            {
                freq[s[left] - 'A']--;
                left++;
            }

            windowLength = right - left + 1;
            maxWindow = Math.Max(maxWindow, windowLength);
        }

        return maxWindow;
    }
}


/*
   CharacterReplacement cr = new CharacterReplacement();
        string input = "AABABBA";
        Console.WriteLine(cr.CharacterReplacementImpl(input, 2));
*/


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