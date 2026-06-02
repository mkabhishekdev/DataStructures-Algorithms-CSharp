using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Interviews
{
    public class ValidParentheses
    {
        public bool ParenthesesCheckImpl(string s)
        {
             if(string.IsNullOrEmpty(s))
            {
                return false;
            }
            
            if(s.Length == 1)
            {
                return false;
            }

            Stack<char> myStack = new Stack<char>();
            if(s[0] == '(' || s[0] == '[' || s[0] == '{')
            {
                myStack.Push(s[0]);
            }
            if(s[0] == ')' || s[0] == ']' || s[0] == '}')
            {
                return false;
            }

            for(int i = 1; i < s.Length; i++)
            {

                if(s[i] == ')' || s[i] == ']' || s[i] == '}')
                {
                    if(myStack.Count > 0)
                    {
                        char inStack = myStack.Peek();
                        if(s[i] == ')' && inStack != '(')
                        {
                            return false;
                        }
                        if(s[i] == ']' && inStack != '[')
                        {
                            return false;
                        }
                        if(s[i] == '}' && inStack != '{')
                        {
                            return false;
                        }
                        myStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                
                if(s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                   
                    myStack.Push(s[i]);
                 
                
                } 
            }
            
            return myStack.Count == 0 ? true:false;
           
        }
    }
}