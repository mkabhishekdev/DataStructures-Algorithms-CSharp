using System;
using DataStructures.BinaryTree;

class Program
{
    static void Main(string[] args)
    {
        DS5_5_IterativePostOrderTraversal pot = new DS5_5_IterativePostOrderTraversal();
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(-1);
        root.right = new TreeNode(11);
        root.left.left = new TreeNode(-2);
        root.left.right = new TreeNode(-3);
        root.right.left = new TreeNode(21);
        root.right.right = new TreeNode(6);
        root.left.right.right = new TreeNode(5);

        List<int> res = pot.PostOrderTraversal(root);

        Console.WriteLine("PostOrder traversal of the given tree is: ");
        for (int i = 0; i < res.Count; i++)
        {
            Console.WriteLine(res[i]);
        }

    }
}

/*
  TreeNode root = new TreeNode(10);
        root.left = new TreeNode(11);
        root.right = new TreeNode(-20);
        root.left.left = new TreeNode(15);
        root.left.right = new TreeNode(12);
        root.right.left = new TreeNode(0);
        root.right.right = new TreeNode(9);
        root.right.left.left = new TreeNode(16);
        root.right.left.right = new TreeNode(18);
*/