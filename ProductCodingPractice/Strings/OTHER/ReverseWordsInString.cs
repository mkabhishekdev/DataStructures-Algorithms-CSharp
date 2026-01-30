using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCodingPractice.Strings.SET1
{
    public class ReverseWordsInString
    {
        public string ReverseWords(string s)
        {
            if (s == null)
            {
                return null;
            }

            string[] mySplitInput = s.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            string result = null;

            for (int i = mySplitInput.Length - 1; i >= 0; i--)
            {
                result = result + mySplitInput[i];

                if(i != 0)
                {
                    result = result + " ";
                }
            }

            return result;
        }
    }
}