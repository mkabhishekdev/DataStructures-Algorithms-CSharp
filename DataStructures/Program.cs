using System;
using DataStructures.BinaryTree;

class Program
{
    static void Main(string[] args)
    {
        DS5_1_DFS_TraversalRecursiveWayImpl dfs = new DS5_1_DFS_TraversalRecursiveWayImpl();
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);
        root.left.right.left = new TreeNode(6);
        root.right = new TreeNode(3);
        root.right.left = new TreeNode(7);
        root.right.right = new TreeNode(8);
        root.right.right.left = new TreeNode(9);
        root.right.right.right = new TreeNode(10);

        Console.WriteLine("DFS - PreOrder traversal of the tree is below: ");
        dfs.PreOrderTraversal(root);

        Console.WriteLine("DFS - InOrder traversal of the tree is below: ");
        dfs.InOrderTraversal(root);

        Console.WriteLine("DFS - PostOrder traversal of the tree is below: ");
        dfs.PostOrderTraversal(root);

    }
}