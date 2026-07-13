using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetThree
{
    public class PalindromicSubSetThree
    {
        int count = 0;

        public int PalindromicSubImpl(string s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                PalindromicCheck(s,i,i); // odd length string
                PalindromicCheck(s,i,i+1); // even length string
            }
            return count;  
        }

        private void PalindromicCheck(string s, int left, int right)
        {
            while((left >= 0) && (right < s.Length) && (s[left] == s[right]))
            {
                count++;
                left--;
                right++;
            }
            
        }
    }
}