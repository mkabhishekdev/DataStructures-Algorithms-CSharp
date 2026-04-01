using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Trees.YourTHINKINGWork
{
    /* My Approach
    1. will do a level order traversal of the tree and will save the values in to a queue
    2. when dequeued from the queue, will store the elements in a list
    3. will sort the list finally in an ascending order
    4. will search for the (k-1)th element and return it
    */

    /* Any optimization later
    You should utilize BST features since already the nodes will be sorted and 
    therefore use InOrder and have a count k
    */

    /* time complexity: O(nlogn)
    space complexity: O(n)
    */

    public class KthSmallest
    {
        public int KthSmallestImpl(TreeNode root, int k)
        {
            if(root == null)
            {
                return 0;
            }           

            Queue<TreeNode> traversalStream = new Queue<TreeNode>();
            traversalStream.Enqueue(root);

            List<int> storage = new List<int>();

            while(traversalStream.Count > 0)
            {
                TreeNode presentNode = traversalStream.Dequeue();

                if(presentNode.left != null)
                {
                    traversalStream.Enqueue(presentNode.left);
                }
                if(presentNode.right != null)
                {
                    traversalStream.Enqueue(presentNode.right);
                }
                
                storage.Add(presentNode.val);
            }

            storage.Sort();

            for(int i = 0; i < storage.Count; i++)
            {
                if(i == (k-1))
                {
                    return storage[i];
                }
            }
            
            return -1;

        }
    }
}