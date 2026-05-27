using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InterviewLabCodeRepo.Interview
{
    public class LongestPalindromicSubstring
    {
        public string LongestPalindromicImpl(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return "";
            }

            if(input.Length == 1)
            {
                return input;
            }

            // starting initialization
            string longestPalindrome = input[0].ToString();
            int maxLength = 1;

            for(int i = 0; i < input.Length; i++)
            {
                int j = i;
                while (j < input.Length)
                {
                    if(IsPalindrome(input, i, j))
                    {       
                        int currentLength = j - i + 1;
                        if(currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            longestPalindrome = input.Substring(i, currentLength);
                        }
                    }
                }
            }  
            return longestPalindrome;
        }

        private bool IsPalindrome(string s, int left, int right)
        {
            while(left < right)
            {
                if(s[left] != s[right])
                {
                    return false;
                }

               left++;
               right--;
            }
            return true;
        }
    }
}