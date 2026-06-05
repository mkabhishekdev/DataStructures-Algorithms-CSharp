using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
global using ProblemSolvingFromFirstPrinciples.Trees;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class PreOrderSetTwo
    {
        public List<int> PreOrderImpl(TreeNode root)
        {
            if(root == null)
            {
                return new TreeNode(0);
            }
            
            List<int> myResult = new List<int>();
            Stack<TreeNode> myStack = new Stack<TreeNode>();
            myStack.Push(root);

            while(myStack.Count > 0)
            {
                TreeNode checkElement = myStack.Pop();

                if(checkElement.left != null || checkElement.right != null)
                {
                    if(checkElement.right != null)
                    {
                        myStack.Push(checkElement.right);
                    }
                    if(checkElement.left != null)
                    {
                        myStack.Push(checkElement.left);
                    }
                }

                myResult.Add(checkElement.val);
            }
            
            return myResult;
        }
    }
}