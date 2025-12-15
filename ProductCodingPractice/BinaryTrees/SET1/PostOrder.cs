using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCodingPractice.BinaryTrees.SET1
{
    public class PostOrder
    {
        public IList<int> PostOrderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            
            if (root == null)
            {
                return result;    
            }

            Stack<TreeNode> s1 = new Stack<TreeNode>();
            Stack<TreeNode> s2 = new Stack<TreeNode>();

            s1.Push(root);

            while (s1.Count != 0)
            {
                root = s1.Pop();
                s2.Push(root);

                if (root.left != null)
                {
                    s1.Push(root.left);
                }
                if (root.right != null)
                {
                    s1.Push(root.right);
                }
            }

            while (s2.Count != 0)
            {
                TreeNode toSend = s2.Pop();
                result.Add(toSend.val);
            }

            return result;
            
        }

    }
}



/*
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
*/