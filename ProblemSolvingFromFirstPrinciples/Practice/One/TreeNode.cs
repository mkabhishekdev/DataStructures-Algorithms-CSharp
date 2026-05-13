using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.One
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
            left = null;
            right = null;
        }
    }
}

/* INPUT

   TreeNode input = new TreeNode(1);
        input.left = new TreeNode(2);
        input.right = new TreeNode(3);
        input.left.left = new TreeNode(4);
        input.left.right = new TreeNode(5);
        input.right.left = new TreeNode(6);
        input.right.right = new TreeNode(7);

*/