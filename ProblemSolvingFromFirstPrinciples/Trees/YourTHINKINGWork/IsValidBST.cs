using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Trees.YourTHINKINGWork
{
    public class IsValidBST
    {
        /* Referred Approach
        1. you need to have a long.min and long.max 
        2. return a '&&' compared result of both leaft and right sub-branches
        */

        /* any optimization later

        */

        /* time complexity: O(2(power of n))
        space complexity: O(1)
        */

        public bool IsValidBSTImpl(TreeNode root)
        {
            return CheckDeep(root, long.MinValue, long.MaxValue);
        }

        private bool CheckDeep(TreeNode node, long min, long max)
        {
            if(node == null)
            {
                return true;
            }

            if((node.val <= min) || (node.val >= max))
            {
                return false;
            }

            return CheckDeep(node.left,min,node.val) && CheckDeep(node.right,node.val,max);
        }
    }
}

    /* FAILED APPROACH & WHY? (did not think in terms of min, max and keeping a range window)
        1. if any value on the left is greater, return false
        2. if any value on the right is lesser, return false
        3. to check over the entire BST, implement the above idea in the form of recursive calls
       
        */ 
        /* CODE:
           if(root.left != null && root.right != null && root != null)
            {
                if((root.left.val >= root.val) || (root.right.val <= root.val))
                {
                    return false;
                }
          
                IsValidBST(root.left);
                IsValidBST(root.right);
            }

            return true;

        */