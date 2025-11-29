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

            TreeNode temp = root;

            if (temp == null)
            {
                return null;
            }

            while (temp != null)
            {
                if (temp.left != null)
                {
                    result.Add(temp.data);
                    PreOrder(temp.left);
                }
                temp = temp.right;
            }

            return result;
        }
    }
}