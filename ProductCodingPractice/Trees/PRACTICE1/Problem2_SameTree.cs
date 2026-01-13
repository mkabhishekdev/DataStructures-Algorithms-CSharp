using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using ProductCodingPractice.BinaryTrees;

namespace ProductCodingPractice.Trees.PRACTICE1
{
    public class Problem2_SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if ((p == null && q != null) || (p != null && q == null))
            {
                return false;
            }
            if (p.val != q.val)
            {
                return false;
            }
            if (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right))
            {
                return true;
            }
            return false;
        }
    }
}

/*
Time Complexity:  O(n)
Space Complexity: O(1)
*/