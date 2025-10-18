using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductFaangCodingPractice.BinaryTrees
{
    public class TreeNode
    {
        public int data;

        public TreeNode right;

        public TreeNode left;

        public TreeNode(int x)
        {
            data = x;
            left = null;
            right = null;
        }
    }
}