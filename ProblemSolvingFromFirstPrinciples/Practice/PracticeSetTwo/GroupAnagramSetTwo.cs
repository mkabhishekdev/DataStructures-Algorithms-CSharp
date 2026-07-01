using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class GroupAnagramSetTwo
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if(strs == null || strs.Length == 0)
            {
                return new List<IList<string>>();
            }

            Dictionary<string, List<string>> frequencyStringMap = new Dictionary<string, List<string>>();

            foreach(string str in strs)
            {
                string frequencyString = GetFrequencyString(str);
 
                if(frequencyStringMap.ContainsKey(frequencyString))
                {
                    frequencyStringMap[frequencyString].Add(str);
                }
                else
                {
                    List<string> strList = new List<string>();
                    strList.Add(str);
                    frequencyStringMap[frequencyString] = strList;
                }
            }

            return new List<IList<string>>(frequencyStringMap.Values);
        }

        public string GetFrequencyString(string str)
        {
            int[] freq = new int[26];

            foreach(char ch in str.ToCharArray())
            {
                freq[ch - 'a']++;
            }
            
            StringBuilder frequencyString = new StringBuilder("");
            char c = 'a';

            foreach(int i in freq)
            {
                frequencyString.Append(c);
                frequencyString.Append(i);
                c++;
            }

            return frequencyString.ToString();
        }

    }
}