using System;
using System.Collections;
using DataStructures.BinaryTree;

public class DS5_3_IterativePreOrderTraversal
{
    public List<int> PreOrderTraversal(TreeNode root)
    {
        List<int> result = new List<int>();

        if (root == null)
        {
            return null;
        }
        Stack<TreeNode> myStack = new Stack<TreeNode>();
        myStack.Push(root);

        while (myStack.Count != 0)
        {
            TreeNode presentNode = myStack.Pop();
            result.Add(presentNode.data);

            if (presentNode.right != null)
            {
                myStack.Push(presentNode.right);
            }
            if (presentNode.left != null)
            {
                myStack.Push(presentNode.left);
            }
        }

        return result;
    }
}