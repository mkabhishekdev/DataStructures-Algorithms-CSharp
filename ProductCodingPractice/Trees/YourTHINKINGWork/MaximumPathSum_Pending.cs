using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCodingPractice.BinaryTrees;

namespace ProductCodingPractice.Trees.YourTHINKINGWork
{
    /*
    APPROACH I CAME UP WITH::

    */

    public class MaximumPathSum_Pending
    {
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
    }
}
  
  // If all test cases not clearing, PRACTICE DEBUGGING
  /* FAILED APPROACH & WHY
  1. Initialize a list to save the nodes which will create a path
  2. But still not completely clear with how a path is created?
  3. If I know the condition for path creation, I will pick the nodes involved in the path creation and add them into 
       my list
  4. Than, I will add the nodes inside my list and return the sum
  */ 