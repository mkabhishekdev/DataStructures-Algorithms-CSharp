using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.One
{
    public class QueueUsingTwoStacks
    {
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();
        
        public void Enqueue(int data)
        {
            stack1.Push(data);
            Console.WriteLine("Element successfully inserted into the queue");
        }

        public int Dequeue()
        {
            while(stack1.Count != 0)
            {
                int item = stack1.Pop();
                stack2.Push(item);
            }

            int dqItem = stack2.Pop();
            
            while(stack2.Count != 0)
            {
                stack1.Push(stack2.Pop());
            }

            return dqItem;
        }

        public int Peek()
        {
            while(stack1.Count != 0)
            {
                stack2.Push(stack1.Pop());
            }

            int peekItem = stack2.Peek();
            
            while(stack2.Count != 0)
            {
                stack1.Push(stack2.Pop());    
            }

            return peekItem;
        }

        public bool IsEmpty()
        {
            if(stack1.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}