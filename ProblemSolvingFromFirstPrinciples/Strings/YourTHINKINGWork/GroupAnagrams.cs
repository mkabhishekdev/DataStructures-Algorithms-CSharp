using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Strings.YourTHINKINGWork
{
    /* My Approach (113/123 case pass) TLE error for huge inputs
    1. start from the first element in the string[], save the count of char in a Dictionary<char,int>
    2. with this Dictionary, search through a loop in the [], where you find elements with similar char count
    3. when you find, save all of them into a list
    4. once you save them into the list, delete those elements from the str[] and also delete the old key-value
       from the dictionary
    5. again do the same above process on the remaining elements in the str[]
    6. if no match found, than also save the single element in a list
    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class GroupAnagrams
    {
        Dictionary<char, int> charCountChecker = new Dictionary<char, int>();

     //   strs = ["eat","tea","tan","ate","nat","bat"]
        public IList<IList<string>> GroupAnagramsImpl(string[] strs)
        {
            if(strs == null || strs.Length == 0)
            {
                return new List<IList<string>>();
            }
            if(strs.Length == 1)
            {
                return new List<IList<string>>
                {
                    new List<string> { strs[0] }
                };
            }
            List<string> myList = new List<string>(strs);

            IList<IList<string>> result = new List<IList<string>>();

            while(myList.Count > 0)
            {
                IList<string> individualResult = new List<string>();
                individualResult.Add(myList[0]);
                Checker(myList[0]);
                for(int i = 1; i < myList.Count; i++)
                {
                    if(IsSameFrequency(myList[i],charCountChecker))
                    {
                        individualResult.Add(myList[i]);
                    }
                }

                HashSet<string> set = new HashSet<string>(individualResult);
                myList.RemoveAll(s => set.Contains(s));
                result.Add(individualResult);
            }
            return result;
        }

        public void Checker(string input)
        {
            charCountChecker = new Dictionary<char, int>();
            foreach(char c in input)
            {
                if(charCountChecker.ContainsKey(c))
                {
                    charCountChecker[c]++;
                }
                else
                {
                    charCountChecker[c] = 1;
                }
            }
        }

        public bool IsSameFrequency(string s, Dictionary<char, int> baseMap)
        {
            Dictionary<char, int> temp = new Dictionary<char, int>(baseMap);

            foreach(char c in s)
            {
                if(!temp.ContainsKey(c))
                {
                    return false;
                }
                temp[c]--;
                if(temp[c] < 0)
                {
                    return false;
                }
            }

            foreach(var kvp in temp)
            {
                if(kvp.Value != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}