using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InterviewLabCodeRepo.Interview
{
    /* My approach
    1. start accessing each element form the wordDict and check if it exists in s
    2. if it exists in s -> remove it from s
    3. keep on iterating the list and check each element with the updated s
    4. if exists continue till end of the list, if any element not found -> return false
    5. if you reach the end of the list and have covered all the elements -> return true
    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class WordBreak
    {
        public bool WordBreakImpl(string s, IList<string> wordDict)
        {
            for(int i = 0; i < wordDict.Count; i++)
            {
                if(s.Contains(wordDict[i]))
                {
                    s = s.Replace(wordDict[i],"").Trim();
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}