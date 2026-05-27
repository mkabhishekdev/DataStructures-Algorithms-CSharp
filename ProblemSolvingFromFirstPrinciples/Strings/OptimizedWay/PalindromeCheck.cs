using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLabCodeRepo.Interview
{
    /* My approach
    1. use two pointer approach to iterate over the string
    2. check if s[i] = s[j] -> i++, j--
    3. if the condition breaks at any -> return false
    4. when i crosses j, it means we have covered the entire string
       return true
    */

    /* any optimization later

    */

    /* time complexity: O(n)
    space complexity: O(1)
    */
    public class PalindromeCheck
    {
        public bool PalindromeImpl(string input)
        {
            if(String.IsNullOrEmpty(input))
            {
                return false;
            }
            
            if(input.Length <= 1)
            {
                return true;
            }

            int i = 0, j = input.Length - 1;
        
    
            while(i < j)
            {
                while((i < j) && (!char.IsLetterOrDigit(input[i])))
                {
                    i++;
                }
                while((i < j) && (!char.IsLetterOrDigit(input[j])))
                {
                    j--;
                }
                if(char.ToLower(input[i]) != char.ToLower(input[j]))
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }
}