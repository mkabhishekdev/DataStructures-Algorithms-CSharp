using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCodingPractice.BinaryTrees.SET1
{
    public class PreOrder
    {
        public IList<int> PreorderTraversal(TreeNode root) 
        {
            IList<int> result = new List<int>();

            if (root == null)
            {
                return new List<int>();
            }

            Stack<TreeNode> myStack = new Stack<TreeNode>();
            myStack.Push(root);

            while (myStack.Count != 0)
            {
                TreeNode currentNode = myStack.Pop();
                result.Add(currentNode.val);

                if (currentNode.right != null)
                {
                    myStack.Push(currentNode.right);
                }
                if (currentNode.left != null)
                {
                    myStack.Push(currentNode.left);
                }
            }

            return result;
           
        }
    }
}