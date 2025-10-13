using System;
using DataStructures.BinaryTree;

class Program
{
    static void Main(string[] args)
    {
        DS5_6_BinarySearchTreeImpl bst = new DS5_6_BinarySearchTreeImpl();
        TreeNode root = new TreeNode(10);
        root.left = new TreeNode(-5);
        root.right = new TreeNode(30);
        root.left.left = new TreeNode(-10);
        root.left.right = new TreeNode(0);
        root.left.right.right = new TreeNode(5);
        root.right.right = new TreeNode(36);

        bst.BinarySearchTree(root, 11);


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