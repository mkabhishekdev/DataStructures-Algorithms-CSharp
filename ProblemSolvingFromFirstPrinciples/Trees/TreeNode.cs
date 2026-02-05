using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCodingPractice.BinaryTrees
{
    public class TreeNode
    {
        public int val;

        public TreeNode right;

        public TreeNode left;

        public TreeNode(int x)
        {
            val = x;
            left = null;
            right = null;
        }
    }
}