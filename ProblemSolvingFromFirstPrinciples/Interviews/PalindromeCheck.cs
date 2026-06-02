using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//"A man, a plan, a canal: Panama"
namespace ProblemSolvingFromFirstPrinciples.Interviews
{
    public class PalindromeCheck
    {
        public bool PalindromeImpl(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return true;
            }

            if(input.Length == 1)
            {
                return true;
            }

            int i = 0, j = input.Length - 1;

            while(i < j)
            {
                /* you need to use while -> cases say ': P', when a space after colon
                involved you need to skip 2 char here, so using 'if' is wrong   */
                while((i < j) && (!char.IsLetterOrDigit(input[i])))
                {
                    i++;
                }
                while((i < j) && (!char.IsLetterOrDigit(input[j])))
                {
                    j--;
                }
                /* ToLowerInvariant() converts a string/character to lowercase using the 
                culture independent(invariant) rules */
                if(char.ToLowerInvariant(input[i]) != char.ToLowerInvariant(input[j]))
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