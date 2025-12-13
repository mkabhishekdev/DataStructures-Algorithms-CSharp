using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCodingPractice.BinaryTrees.SET1
{
    public class PostOrder
    {
        public IList<int> PostOrderTraversal(TreeNode root)
        {
            Stack<int> myStack = new Stack<int>();
            IList<int> result = new List<int>();

            TreeNode curr = root;

            while (curr.left != null)
            {
                curr = curr.left;
            }
            myStack.Push(curr.val);

            while(myStack.Count != 0)
            {
                int top = myStack.ElementAt(0);
            }
        }   
        
    }
}