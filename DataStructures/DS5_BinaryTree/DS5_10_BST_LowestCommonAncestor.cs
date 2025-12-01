using System;
using System.Runtime.InteropServices;
using DataStructures.BinaryTree;

public class DS5_10_BST_LowestCommonAncestor
{
    public int LowestCommonAncestor(TreeNode root, TreeNode firstNode, TreeNode secondNode)
    {

        if (root.data > Math.Max(firstNode.data, secondNode.data))
        {
            return LowestCommonAncestor(root.left, firstNode, secondNode);
        }
        else if (root.data < Math.Min(firstNode.data, secondNode.data))
        {
            return LowestCommonAncestor(root.right, firstNode, secondNode);
        }
        else
        {
            return root.data;
        }

    }

}

/*
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
*/