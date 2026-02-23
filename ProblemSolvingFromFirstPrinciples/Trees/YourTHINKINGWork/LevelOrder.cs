using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCodingPractice.BinaryTrees;

namespace ProblemSolvingFromFirstPrinciples.Trees.YourTHINKINGWork
{
    /*
    PARTIAL RIGHT,REFERRED APPROACH:
    1. Check if root is null, if it is return null
    2. Will use Queue for BFS and keeping track of nodes per level
    3. Start from the root,enqueue root to Queue. 
    4. From here I went wrong. The main idea is to 'track the queue size' -> that corresponds to the level size
    5. You need to insert each level size as a list into the resultant list
    6. Return the List
    */
    /*
    Time Complexity: O(n)
    Space Complexity: O(n)
    */
    public class LevelOrder
    {
        public IList<IList<int>> LevelOrderImpl(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Queue<TreeNode> trackerQueue = new Queue<TreeNode>();

            if(root == null)
            {
                return result;
            }

            trackerQueue.Enqueue(root);

            while(trackerQueue.Count > 0)
            {
                int levelSize = trackerQueue.Count;
                IList<int> currentLevel = new List<int>();

                for(int i = 0; i < levelSize; i++)
                {
                    TreeNode current = trackerQueue.Dequeue();
                    currentLevel.Add(current.val);
                    if(current.left != null)
                    {
                        trackerQueue.Enqueue(current.left);
                    }
                    if(current.right != null)
                    {
                        trackerQueue.Enqueue(current.right);
                    }
                }

                result.Add(currentLevel);
            }
            
            return result;
        }
    }
}

     // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
    /* FAILED APPROACH & WHY? (Queue size count value had to be tracked & had to think in terms of 'level' while dequeue process)
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