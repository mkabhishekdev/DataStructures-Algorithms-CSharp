using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using ProductCodingPractice.BinaryTrees;

/*
APPROACH I CAME UP WITH:
1. Use a Queue 
2. First push the corresponding elements from both p and q in the form Queue<(TreeNode,TreeNode)> into the queue
3. Check if condition for all failing conditions
4. If not, Enqueue the next left,right sub tree nodes
*/

namespace ProductCodingPractice.Trees.PRACTICE1
{
    public class Problem2_SameTree
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
Time Complexity:  O(n)
Space Complexity: O(1)
*/