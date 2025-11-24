using System;
using DataStructures.BinaryTree;

class Program
{
    static void Main(string[] args)
    {
        DS5_11_BT_LowestCommonAncestor lca = new DS5_11_BT_LowestCommonAncestor();
        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(6);
        root.right = new TreeNode(8);
        root.left.left = new TreeNode(2);
        root.left.right = new TreeNode(11);
        root.left.right.left = new TreeNode(9);
        root.left.right.right = new TreeNode(5);
        root.right.right = new TreeNode(13);
        root.right.right.left = new TreeNode(7);

        TreeNode first = root.left.left;  // when you trying to search, specify that path. Don't create new TreeNode(2)
        TreeNode second =  root.left.right.right; // when you trying to search, specify that path. Don't create new TreeNode(2)

        TreeNode result = lca.LowestCommonAncestor(root, first, second);

        if (result != null)
        {
            Console.WriteLine(result.data);
        }
        else
        {
            Console.WriteLine("No common ancestor found");
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