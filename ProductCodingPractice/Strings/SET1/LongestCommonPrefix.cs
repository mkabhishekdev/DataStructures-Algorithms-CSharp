using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ProductCodingPractice.Strings.SET1
{
    public class LongestCommonPrefix
    {
        public string LongestCommonPrefixCheck(string[] strs)
        {
            if (strs == null)
            {
                return null;
            }

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, (prefix.Length - 1));
                }
            }

            return prefix;
        }
        
    }
}