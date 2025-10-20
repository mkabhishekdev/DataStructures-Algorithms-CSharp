using System;
using DataStructures.BinaryTree;

class Program
{
    static void Main(string[] args)
    {
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