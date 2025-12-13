using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCodingPractice.StackQueue.SET1
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack myStack = new Stack();

            List<char> store = s.ToList();

            foreach(char c in store)
            {
                myStack.Push(c);
                
            }
        }
    }
}