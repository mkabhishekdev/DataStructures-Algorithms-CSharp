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

/*
        TreeNode root = new TreeNode(-10);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);

  */