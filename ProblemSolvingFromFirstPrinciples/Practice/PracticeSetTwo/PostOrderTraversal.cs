using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class PostOrderTraversal
    {
        public List<int> POTreeImpl(TreeNode root)
        {
            if(root == null)
            {
                return new List<int>();
            }

            Stack<TreeNode> trackerStack = new Stack<TreeNode>();
            List<int> result = new List<int>();
            TreeNode lastVisited = null;

            TreeNode curr = root;
            trackerStack.Push(curr);

            while((curr != null) || (trackerStack.Count > 0))
            {
                while(curr != null)
                {
                    trackerStack.Push(curr);
                    curr = curr.left;
                }
                
                TreeNode peekNode = trackerStack.Peek();

                if(peekNode.right != null && lastVisited != peekNode.right)
                {
                    curr = peekNode.right;
                }
                else
                {
                    result.Add(peekNode.val);
                    lastVisited = trackerStack.Pop();
                }
            }

            return result;
        }
    }
}