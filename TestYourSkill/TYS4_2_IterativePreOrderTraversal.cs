using System;
using System.Collections;
using System.Xml;

public class TYS4_2_IterativePreOrderTraversal
{
    public class TreeNode
    {
        public int data;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            data = x;
            left = null;
            right = null;
        }
    }
    TreeNode root = null;

    public void PreOrder(TreeNode root)
    {
        if (root == null)
        {
            Console.WriteLine("No tree present");
            return;
        }

        List<int> result = new List<int>();
        Stack<TreeNode> myStack = new Stack<TreeNode>();
        myStack.Push(root);

        while (!myStack.Count == 0)
        {
            while (root.left != null)
            {
                TreeNode x = myStack.Pop();
                result.Add(x.data);

                myStack.Push(root.left);
            }
            result.Add(myStack.Pop().data);

        }


    }
}

// SCORE = 4/10