using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class AnagramCheck
    {
        public bool CheckAnagramImpl(string s, string t)
        {
            if(s.Length == 0 || t.Length == 0)
            {
                return false;
            }

            if(s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> counts = new Dictionary<char, int>();
            
            foreach(char ch in s)
            {
                if(!counts.ContainsKey(ch))
                {
                    counts.Add(ch,1);
                }
                else
                {
                    counts[ch] += 1;
                }
            }
            
            foreach(char c in t)
            {
                if(!counts.ContainsKey(c))
                {
                    return false;
                }
                
                counts[c]--;

                if(counts[c] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}