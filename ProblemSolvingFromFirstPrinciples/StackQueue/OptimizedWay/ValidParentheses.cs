using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.One
{
    public class ValidParentheses
    {
        /* My approach
        1. use a stack to store each char from the string
        2. validated each char with top in stack
        */

        /* any optimization later

        */

        /* time complexity:
        space complexity:
        */
        public bool ValidParenthesesImpl(string input)
        {
            Stack<char> myStack = new Stack<char>();

            for(int i = 0; i < input.Length; i++)
            {
                if((input[i] == '(') || (input[i] == '[') || (input[i] == '{') )
                {
                    myStack.Push(input[i]);
                }
                if((input[i] == ')') || (input[i] == ']') || (input[i] == '}') )
                {
                    if(myStack.Count == 0)
                    {
                        return false;
                    }
                    
                   char top = myStack.Pop();

                    if((input[i] == ')' && top != '(') || (input[i] == ']' && top != '[') || (input[i] == '}' && top != '{'))
                    {
                        return false;    
                    }
                }
            }
            return myStack.Count == 0;
        }
    }
}