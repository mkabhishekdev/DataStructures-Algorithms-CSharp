using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCodingPractice.BinaryTrees;


namespace ProductFaangCodingPractice.BinaryTrees.SET1
{
    public class InOrder
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = null;

            if (root == null)
            {
                return null;
            }

            InorderTraversal(root.left);
            result.Add(root.val);
            InorderTraversal(root.right);

            return result;
        }

    }
}


// SCORE = 3/10

/*
  IList<int> result = new IList<int>();
            Stack<int> myStack = new Stack<int>();

            while (root.left != null)
            {
                root = root.left;
            }
            myStack.Push(root);

            while(myStack.Count > 0)
            {
                root = myStack.Pop();
                result.Add(root.data);

                
            }
*/