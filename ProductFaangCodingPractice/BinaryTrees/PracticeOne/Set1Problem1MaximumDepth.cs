//TIME: 45 minutes , Easy:10pts, Med:20pts, Hard:30pts

using System;
using System.Collections;
using ProductFaangCodingPractice.BinaryTrees;

public class Set1Problem1MaximumDepth
{
    public int MaxDepth(TreeNode root)
    {
        Queue<TreeNode> myQueue = new Queue<TreeNode>();
        int level = 0;

        if (root == null)
        {
            return -1;
        }

        level = 1;
        TreeNode current = root;

        while (current != null)
        {
            if (current.left.data != null)
            {
                if (current.left.left != null || current.left.right != null)
                {
                    current = current.left;
                }
                myQueue.Enqueue(current.left);
            }
            if (current.right.data != null)
            {
                if (current.right.left != null || current.right.right != null)
                {
                    current = current.right;
                }
                myQueue.Enqueue(current.right);
            }
            while (!myQueue.Count == 0)
            {
                myQueue.Dequeue();
            }
            level++;
        }

        return level;

    }

}

// SCORE: 2.5/10