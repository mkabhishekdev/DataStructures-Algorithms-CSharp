using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Trees.YourTHINKINGWork
{
    /* My Approach 
    1. check with base cases, if both the trees are null -> return true and if both 
       one of the trees is null -> return false
    2. search for the 'root' of the subRoot tree in the root tree
    3. once found
          - compare all the children of the subroot with the (subbranch of the root tree) where you found
            both the similar roots
          - apply recursion to find the equality of the corresponding nodes in both the trees
          - return true -> if all match
          - return false -> if there is any mismatch
    */

    /* any optimization later

    */

    /* time complexity: O(n)
    space complexity: O(1)
    */
    public class SubTreeCheck
    {
        public bool IsSubTree(TreeNode root, TreeNode subRoot)
        {
            if(subRoot == null)
            {
                return true;
            }

            if(root == null)
            {
                return false;
            }
            
            if((root.val == subRoot.val) && (IsSameTree(root, subRoot)))
            {
                return true;
            }

            return IsSubTree(root.left, subRoot) || IsSubTree(root.right, subRoot);
        }

        private bool IsSameTree(TreeNode p, TreeNode q)
        {
            if(p == null && q == null)
            {
                return true;
            }
            if(p == null || q == null || p.val != q.val)
            {
                return false;
            }
            
            return IsSameTree(p.left,q.left) && IsSameTree(p.right,q.right);

        }
    }
}