using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using ProductCodingPractice.BinaryTrees;

namespace ProductCodingPractice.Trees.YourTHINKINGWork
{
    /*
    REFERRED APPROACH:
    1. You have to use Recursion in sub trees firstly.
    2. Create a max path sum variable which keeps getting updated with the max sum value.
    3. Use Math.Max(x,y) to find the max in left node and max in right node in each subtree.
    4. Compare max path sum value with (left+right+node) value and store whichever is greater in max path sum value.
    5. Return max path sum value
    */

    /*
    Time Complexity: O(n)
    Space Complexity: O(h)
    */

    public class MaximumPathSum
    {
        int max_path_sum;

        public int MaxPathSumImpl(TreeNode root)
        {
            max_path_sum = int.MinValue;
            MaxSum(root);
            return max_path_sum;

        }

        public int MaxSum(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftNode = Math.Max(0, MaxSum(node.left));
            int rightNode = Math.Max(0, MaxSum(node.right));
            max_path_sum = Math.Max(max_path_sum, leftNode + rightNode + node.val);

            return Math.Max(leftNode, rightNode) + node.val;
        }
    }
}
  
// If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
  /* FAILED APPROACH & WHY
  1. Initialize a list to save the nodes which will create a path
  2. But still not completely clear with how a path is created?
  3. If I know the condition for path creation, I will pick the nodes involved in the path creation and add them into 
       my list
  4. Than, I will add the nodes inside my list and return the sum
    public int MaxPathSumImpl(TreeNode root)
        {
            if (root == null)
            {
                return -1;
            }

            List<TreeNode> pathCreatedStore = new List<TreeNode>();

            TreeNode temp = root;

            return 0;
        }
  */ 
  
  /*
MaximumPathSum mps = new MaximumPathSum();
        TreeNode root = new TreeNode(-10);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);

        Console.WriteLine(mps.MaxPathSumImpl(root));

  */