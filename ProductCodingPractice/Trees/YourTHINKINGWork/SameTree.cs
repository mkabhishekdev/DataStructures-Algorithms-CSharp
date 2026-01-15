using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ProductCodingPractice.BinaryTrees;
using System.Linq;

/*
APPROACH I CAME UP WITH:
1. Use a Queue 
2. First push the corresponding elements from both p and q in the form Queue<(TreeNode,TreeNode)> into the queue
3. Check if condition for all failing conditions
4. If not, Enqueue the next left,right sub tree nodes
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
      
            
            Queue<(TreeNode, TreeNode)> myQueue = new Queue<(TreeNode, TreeNode)>();

            myQueue.Enqueue((p, q));

            while (myQueue.Count > 0)
            {
                var (nodeP, nodeQ) = myQueue.Dequeue();

                if (nodeP == null && nodeQ == null)
                {
                    continue;
                }
                if (nodeP == null || nodeQ == null)
                {
                    return false;
                }
                if(nodeP.val != nodeQ.val)
                {
                    return false;
                }

                myQueue.Enqueue((nodeP.left, nodeQ.left));
                myQueue.Enqueue((nodeP.right, nodeQ.right));
                
            }
          return true;                
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