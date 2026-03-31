using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Trees.YourTHINKINGWork
{
    /* Referred Approach
     1. create a dictionary<int, int> to store the inorder values along with the index
     2. create a helper method. Idea is to pick the root from the preorder[], find it in what position does 
        this root exist in the inorder[]. This will give the mid in the inorder
     3. Once you find the mid in inorder, the elements to the left of mid belong to the left sub branch
        and elements to the right of mid belong to the right subbranch
     4. keep running it though recursive calls within the sub-branches
     5. return the root
    */

    /* any optimization later 

    */

    /* time complexity: O(n)
    space complexity: O(n)  -> dictionary creation extra space
    */

    public class BuildTree
    {
        public TreeNode BuildTreeImpl(int[] preorder, int[] inorder)
        {
            Dictionary<int,int> storeInOrder = new Dictionary<int, int>();

            for(int i = 0; i < inorder.Length; i++)
            {
                if(!storeInOrder.ContainsKey(inorder[i]))
                {
                    storeInOrder[inorder[i]] = i;
                }
            }   
            
            return HelperBuilder(preorder, storeInOrder, 0, 0, inorder.Length - 1);
        }

        private TreeNode HelperBuilder(int[] preorder, Dictionary<int,int> storeInOrder, int rootIndex, int left, int right)
        {
            TreeNode root = new TreeNode(preorder[rootIndex]);

            int mid = storeInOrder[preorder[rootIndex]];

            if(mid > left)
            {
                root.left = HelperBuilder(preorder,storeInOrder,rootIndex + 1,left,mid - 1);
            }
            if(mid < right)
            {
                root.right = HelperBuilder(preorder, storeInOrder,rootIndex+mid-left+1 , mid+1, right);
            }

            return root;
        }
    }
}

  // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY? (you did not think in terms of using the preorder[],inorder[] already given
        , like get the root from preorder[], find the mid in inorder[] -> this would have essentially divided the
        [] into left and right and hence you could go ahead applying recursion on both left and right subbranches)
   1. Will start with the preorder[] given
    2. declare a queue, take the first element from the preorder[] which will be the root and push it into the 
       queue
    3. start to pick the element to dequeue() from the queue
    4. if it has both left and right node, push them into the queue
    5. if it has either left/right -> push that particular node
    6. if none, move forward
    7. save the dequeued element from the queue into a result[]
       
        */ 
        /* CODE:
        Queue<int> treeBuilderQueue = new Queue<int>();
            int[] result = new int{};

            for(int i = 0; i < preorder.Length; i++)
            {
                treeBuilderQueue.Enqueue(preorder[i]);
                
                if(preorder[i+1] != null && preorder[i+2] != null)
                {
                    treeBuilderQueue.Enqueue(preorder[i+1]);
                    treeBuilderQueue.Enqueue(preorder[i+2]);
                }

                result.Add(treeBuilderQueue.Dequeue());
            }

        */