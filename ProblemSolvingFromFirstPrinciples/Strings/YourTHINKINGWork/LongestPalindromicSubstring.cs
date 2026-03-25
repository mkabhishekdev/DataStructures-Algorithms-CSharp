using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Strings.YourTHINKINGWork
{
    /* My Approach
    1. use two pointers i and j
    2. i starts from the starting char at s
    3. j starts from end of s
    4. keeping a[i] in its position, start to move j to find where a[j] = a[i], do j--
    5. if a[i] is not found, do i++ and also move back j to end
    6. keep doing above, when you find a[j] = a[i]
    7. immediately check when the above satisfies, if a[i++] = a[j++], If yes do i++,j--
    8. if not, keeping i wherever it is, again take back j to end
    9. keep doing this until (i < j)
   */
    /* any optimization later

    */

    /*
    time complexity:
    space complexity:
    */
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;

            while(i < j)
            {
                for(j = s.Length - 1; j > i; j--)
                {
                    if(s[j] == s[i])
                    {
                        if(PalindromeTest(s.Substring(i,j-i+1)))
                        {
                            return s.Substring(i,j-i+1);
                        }
                        else
                        {
                            i++;
                            j = s.Length - 1;
                        }
                    }
                }
                i++;
                j = s.Length - 1;
            }
            return "";
        }

        public bool PalindromeTest(string input)
        {
            string front = input[0].ToString();
            string end = input[input.Length - 1].ToString();

            for(int i = 1; i < input.Length; i++)
            {
                front += input[i].ToString();
            }

            for(int i = input.Length - 2; i >= 0; i--)
            {
                end += input[i].ToString();
            }

            if(front.Equals(end))
            {
                return true;
            }

            return false;
        }
    }

}