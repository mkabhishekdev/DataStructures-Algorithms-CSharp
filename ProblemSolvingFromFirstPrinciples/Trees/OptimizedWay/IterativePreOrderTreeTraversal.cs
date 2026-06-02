using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ProblemSolvingFromFirstPrinciples.Trees
{
    /* My approach (PREORDER: ROOT -> LEFT -> RIGHT)
     1. keep a stack
     2. check if root exists, if exists -> push into the stack
     3. inside a while condition checking stack count to 0 condition, pop the element -> put it in list. check if 
        left, right nodes exist. do the below
     3. the order of pushing now has to be right to left. since stack(LIFO) you want to pop left out first
     4. keep a list to store the result
    */

    /* any optimization later

    */

    /* time complexity: O(n) - traverse through the entire treenode
    space complexity: O(n)  - using a list extra space
    */
    public class IterativePreOrderTreeTraversal
    {
        public List<int> PreOrderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();

            if(root == null)
            {
                return result;
            }

            Stack<TreeNode> myStack = new Stack<TreeNode>();
            myStack.Push(root);

            while(myStack.Count > 0)
            {
                TreeNode checkElement = myStack.Pop();
                result.Add(checkElement.val);

                if(checkElement.right != null)
                {
                    myStack.Push(checkElement.right);
                }
                if(checkElement.left != null)
                {
                    myStack.Push(checkElement.left);
                }
            }
            
            return result;
        }
    }
}