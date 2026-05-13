using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.One
{
    /* My approach
    1. take a stack and also a current pointer for backtracking
    2. declare a current storing root if exists to start with
    3. check for the while condition (curr != null) or stack.count > 0
    4. go all the way to the left
    5. once the left is null, before popping the element check if right exists. if yes, still
       do not pop the current element. push the right element into the stack
    6. continue the above till the while breaks
    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class IterativePostOrderTraversal
    {
        public List<int> PostOrderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();

            if(root == null)
            {
                return new List<int>();
            }

            TreeNode current = root;
            Stack<TreeNode> myStack = new Stack<TreeNode>();
            
            TreeNode lastVisited = null;

            while((current != null) || (myStack.Count > 0))
            {
                while(current != null)
                {
                    myStack.Push(current);
                    current = current.left;
                }
                
                TreeNode peekNode = myStack.Peek();

                if((peekNode.right != null) && (lastVisited != peekNode.right))
                {
                    current = peekNode.right;
                }
                else
                {
                    result.Add(peekNode.val);
                    lastVisited = myStack.Pop();
                }  
            }

            return result;
        }
    }
}