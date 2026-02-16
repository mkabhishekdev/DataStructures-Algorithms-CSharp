using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Trees.YourTHINKINGWork
{
    /*
    APPROACH I CAME UP WITH:
    1. Check if root is null, if it is return null
    2. Will use Queue for BFS and keeping track of nodes per level
    3. Start from the root,enqueue root to Queue. 
    4. Now peek through the queue, starting from the first element.check if left node exists -> if yes,
       first dequeue the element and save it in a IList<IList<int>>
    5. Now if left node exists, check if right node exists. Push both of them to queue. if left exist, right no
       enqueue left. if right exist, left null -> enqueue right
    6. So everytime create a condition to do the same process from the front element in the queue
    7. Return the IList
    */
    /*
    Time Complexity:
    Space Complexity:
    */
    public class LevelOrder
    {
        public IList<IList<int>> LevelOrderImpl(TreeNode root)
        {
            IList<IList<int>> result = new IList<IList<int>>();
            Queue<TreeNode> trackerQueue = new Queue<TreeNode>();

            if(root == null)
            {
                return null;
            }

            trackerQueue.Enqueue(root);

            IList<int> separateLevels = new IList<int>();

            while(trackerQueue.Peek() != null)
            {
                TreeNode operatingNode = trackerQueue.Peek();
                separateLevels = new IList<int>();

          
                    separateLevels.Add(operatingNode.val);
                    trackerQueue.Dequeue();

                    if(operatingNode.left != null)
                    {
                        trackerQueue.Enqueue(operatingNode.left);
                        if(operatingNode.right != null)
                        {
                            trackerQueue.Enqueue(operatingNode.right);
                        }
                    }        
                

                result.Add(separateLevels);
            }

        }
    }
}

     // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
    /* FAILED APPROACH & WHY?

       
    */ 