using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.One
{
    /* My approach
     1. use a stack and also a current pointer is needed since backtracking is involved
     2. start a while condition checking if current is null or stack is null
     3. search all the way to left 
     4. pop the element -> store it in the list
     5. now once backtracked, check if right exists. push it into the stack
     6. continue the above process
    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class IterativeInorderTreeTraversal
    {
        public List<int> InorderTreeTraversal(TreeNode root)
        {
            List<int> result = new List<int>();

            if(root == null)
            {
                return new List<int>();
            }

            Stack<TreeNode> myStack =  new Stack<TreeNode>();
            TreeNode current = root;

            while((current != null) || (myStack.Count > 0))
            {
                while(current != null)
                {
                    myStack.Push(current);
                    current = current.left;
                }

                TreeNode removeIt = myStack.Pop();
                result.Add(removeIt.val);

                current = removeIt.right;
               
            }

            return result;
        }
    }
}