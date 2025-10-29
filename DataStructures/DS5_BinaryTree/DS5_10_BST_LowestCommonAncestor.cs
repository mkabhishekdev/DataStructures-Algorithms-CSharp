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