using System;
using DataStructures.BinaryTree;

public class DS5_9_LevelOrderTraversalImpl
{
    public void LevelOrderTraversal(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        Queue<TreeNode> q1 = new Queue<TreeNode>();
        Queue<TreeNode> q2 = new Queue<TreeNode>();

        q1.Enqueue(root);

        while ((q1.Count > 0) || (q2.Count > 0))
        {
            while (q1.Count > 0)
            {
                root = q1.Dequeue();
                Console.Write(root.data);
                if (root.left != null)
                {
                    q2.Enqueue(root.left);
                }
                if (root.right != null)
                {
                    q2.Enqueue(root.right);
                }
            }

            Console.WriteLine();

            while (q2.Count > 0)
            {
                root = q2.Dequeue();
                Console.Write(root.data);
                if (root.left != null)
                {
                    q1.Enqueue(root.left);
                }
                if (root.right != null)
                {
                    q1.Enqueue(root.right);
                }
            }

            Console.WriteLine();
        }
    }
}


/*
    DS5_9_LevelOrderTraversalImpl loti = new DS5_9_LevelOrderTraversalImpl();
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(3);
        root.left.right = new TreeNode(6);
        root.left.right.right = new TreeNode(8);
        root.right = new TreeNode(2);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(5);
        root.right.left.left = new TreeNode(9);
        root.right.left.right = new TreeNode(10);

        loti.LevelOrderTraversal(root);
*/