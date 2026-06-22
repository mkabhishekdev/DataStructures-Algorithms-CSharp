using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class InorderSetTwo
    {
        public List<int> InorderImpl(TreeNode root)
        {
            if(root == null)
            {
                return new List<int>();
            }
            
            TreeNode curr = root;
            Stack<TreeNode> myStack = new Stack<TreeNode>();
            myStack.Push(curr);
            List<int> res = new List<int>();

            while((myStack.Count > 0) || (curr != null))
            {
                while(curr != null)
                {
                    myStack.Push(curr);
                    curr = curr.left;
                }

                TreeNode removeIt = myStack.Pop();
                res.Add(removeIt.val);

                curr = removeIt.right;
            }

            return res;
        }
    }
}