using System;
using System.Collections;
using DataStructures.BinaryTree;

public class DS5_2_BFS_LevelOrderTraversalImpl
{
    public List<List<int>> BFSTraversal(TreeNode root)
    {
        List<List<int>> bfsResult = new List<List<int>>();

        if (root == null)
        {
            return bfsResult;
        }

        Queue<TreeNode> storageQueue = new Queue<TreeNode>();
        storageQueue.Enqueue(root);

        while (storageQueue.Count > 0)
        {
            int size = storageQueue.Count;

            List<int> subList = new List<int>();
            while (size > 0)
            {
                TreeNode currentNode = storageQueue.Dequeue();
                subList.Add(currentNode.data);

                if (currentNode.left != null)
                {
                    storageQueue.Enqueue(currentNode.left);
                }
                if (currentNode.right != null)
                {
                    storageQueue.Enqueue(currentNode.right);
                }
                size--;
            }
            bfsResult.Add(subList);
        }
        return bfsResult;
    }

}

/*
     DS5_2_BFS_TraversalImpl bfs = new DS5_2_BFS_TraversalImpl();
        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);
*/