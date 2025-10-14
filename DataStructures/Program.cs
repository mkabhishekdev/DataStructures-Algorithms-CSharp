using System;
using DataStructures.BinaryTree;

class Program
{
    static void Main(string[] args)
    {
        DS5_8_HeightOfBinaryTree hobt = new DS5_8_HeightOfBinaryTree();
        TreeNode root = new TreeNode(10);
        root.left = new TreeNode(5);
        root.right = new TreeNode(6);
        root.right.left = new TreeNode(8);
        root.right.right = new TreeNode(7);
        root.right.right.right = new TreeNode(4);

        int res = hobt.HeightOfTree(root);
        Console.WriteLine("Height of the binary tree: " + res);


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