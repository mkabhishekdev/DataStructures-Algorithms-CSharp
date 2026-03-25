using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Strings.OptimizedWay
{
    /* Idea
    - Convert each string into a key
    - Same key → same group
    */
    public class GroupAnagramsOptimized
    {
        public IList<IList<string>> GroupAnagramsOptimizedImpl(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            foreach(string s in strs)
            {
                char[] chars = s.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);

                if(!map.ContainsKey(key))
                {
                    map[key] = new List<string>();
                }

                map[key].Add(s);
            }      

            return map.Values
                      .Select(list => (IList<string>)list)
                      .ToList();
        } 
    }
}