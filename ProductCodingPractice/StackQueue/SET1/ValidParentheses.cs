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
            if(((s.Length)%2) != 0)
            {
                return false;
            }

            Stack<char> store = new Stack<char>();

            foreach (char c in s)
            {
                if ((c == '(') || (c == '{') || (c == '['))
                {
                    store.Push(c);
                }
                else if ((c == ')') && (store.Count() != 0) && (store.Peek() == '('))
                {
                    store.Pop();
                }
                else if ((c == ']') && (store.Count() != 0) && (store.Peek() == '['))
                {
                    store.Pop();
                }
                else if ((c == '}') && (store.Count() != 0) && (store.Peek() == '{'))
                {
                    store.Pop();
                }
            }

            if (store.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


 
/*
Stack myStack = new Stack();

            List<char> store = s.ToList();

            foreach(char c in store)
            {
                myStack.Push(c);
                
            }
*/
