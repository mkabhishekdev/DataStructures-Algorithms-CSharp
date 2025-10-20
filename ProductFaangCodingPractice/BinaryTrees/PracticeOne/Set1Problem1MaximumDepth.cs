//TIME: 45 minutes , Easy:10pts, Med:20pts, Hard:30pts

using System;
using System.Collections;
using ProductFaangCodingPractice.BinaryTrees;

public class Set1Problem1MaximumDepth
{
    public int MaxDepth(TreeNode root)
    {
        Queue<TreeNode> myQueue = new Queue<TreeNode>();

        if (root == null)
        {
            return 0;
        }

        myQueue.Enqueue(root);
        int depth = 0;

        while(myQueue.Count > 0)
        {
            int levelCount = myQueue.Count;
            depth++;    

            for(int i = 0; i < levelCount; i++)
            {
                TreeNode removeElement = myQueue.Dequeue();
                if (removeElement.left != null)
                {
                    myQueue.Enqueue(removeElement.left);
                }
                if(removeElement.right != null)
                {
                    myQueue.Enqueue(removeElement.right);
                }
            }
        }
        return depth;
    }

}

// SCORE: 2.5/10, Above is reviewed code 