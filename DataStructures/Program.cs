using System;
using DataStructures.BinaryTree;

class Program
{
    static void Main(string[] args)
    {
        DS5_10_BST_LowestCommonAncestor lca = new DS5_10_BST_LowestCommonAncestor();
        TreeNode root = new TreeNode(10);
        root.left = new TreeNode(-10);
        root.right = new TreeNode(30);
        root.left.right = new TreeNode(8);
        root.left.right.left = new TreeNode(6);
        root.left.right.right = new TreeNode(9);
        root.right.left = new TreeNode(25);
        root.right.right = new TreeNode(60);
        root.right.left.right = new TreeNode(28);
        root.right.right.right = new TreeNode(78);

        TreeNode first = new TreeNode(28);
        TreeNode second = new TreeNode(78);

        Console.WriteLine(lca.LowestCommonAncestor(root, first, second));

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