using System;
using System.Collections;
using DataStructures.BinaryTree;

// left -> root -> right
public class DS5_4_IterativeInOrderTraversal
{
    public List<int> InOrderTraversal(TreeNode root)
    {
        if (root == null)
        {
            return null;
        }

        List<int> result = new List<int>();
        Stack<TreeNode> myStack = new Stack<TreeNode>();

        while (true)
        {
            if (root != null)
            {
                myStack.Push(root);
                root = root.left;
            }
            else
            {
                if (myStack.Count == 0)
                {
                    break;
                }
                root = myStack.Pop();
                result.Add(root.data);
                root = root.right;
            }
        }

        return result;

    }

}

/*
    DS5_4_IterativeInOrderTraversal iit = new DS5_4_IterativeInOrderTraversal();
        TreeNode root = new TreeNode(10);
        root.left = new TreeNode(11);
        root.right = new TreeNode(16);
        root.left.left = new TreeNode(2);
        root.left.right = new TreeNode(-1);
        root.right.left = new TreeNode(10);
        root.right.left.left = new TreeNode(9);
        root.right.left.right = new TreeNode(11);

        List<int> myResult = iit.InOrderTraversal(root);

        Console.WriteLine("Inorder traversal of the given tree is: ");
        for (int i = 0; i < myResult.Count; i++)
        {
            Console.WriteLine(myResult[i]);
        }
*/