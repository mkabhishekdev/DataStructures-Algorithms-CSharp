using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ProductCodingPractice.BinaryTrees;
using System.Linq;

/*
MY APPROACH:

*/

namespace ProductCodingPractice.Trees.YourTHINKINGWork
{
    public class SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if (p == null && (q != null))
            {
                return false;
            }
            if (p != null && (q == null))
            {
                return false;
            }

           
        }

     
    }
}

/*
FAILED APPROACHES & WHY:
Tried PreOrder, Save the list approach:
1. Get the preorder of p and store it in a list
2. Get the preorder of q and store it in a list
3. Compare both the lists, if they are equal -> return true
4. Else return false
Why: It fails for a condition: Because preorder traversal skips null children, two trees with different 
     structures can produce the same preorder sequence.
*/