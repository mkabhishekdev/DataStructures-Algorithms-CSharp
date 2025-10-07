using System;
using System.Collections;
using DataStructures.BinaryTree;

public class DS5_5_IterativePostOrderTraversal()
{
    public List<int> PostOrderTraversal(TreeNode root)
    {
        if (root == null)
        {
            return null;
        }

        List<int> myResult = new List<int>();
        Stack<TreeNode> stack1 = new Stack<TreeNode>();
        Stack<TreeNode> stack2 = new Stack<TreeNode>();

        stack1.Push(root);

        while (stack1.Count != 0)
        {
            root = stack1.Pop();
            stack2.Push(root);

            if (root.left != null)
            {
                stack1.Push(root.left);
            }
            if (root.right != null)
            {
                stack1.Push(root.right);
            }

        }

        while (stack2.Count != 0)
        {
            TreeNode toDisplay = stack2.Pop();
            myResult.Add(toDisplay.data);
        }

        return myResult;
    }
}

/*
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
*/