using System;
using System.Xml;
using DataStructures.BinaryTree;

public class DS5_7_BSTInsertionImpl
{
    public void Insertion(TreeNode root, int inputData)
    {
        if (root == null)
        {
            Console.WriteLine("No BST to insert");
            return;
        }

        TreeNode present = null;
        TreeNode current = root;

        while (current != null)
        {

            if (inputData < current.data)
            {
                present = current;
                current = current.left;
            }
            if (inputData > current.data)
            {
                present = current;
                current = current.right;
            }

        }

        if (present.data > inputData)
        {
            current.left.data = inputData;
            Console.WriteLine("Data inserted to the left of the BST");
        }
        if(present.data < inputData)
        {
            current.right.data = inputData;
            Console.WriteLine("Data inserted to the right of the BST");
        }
        

    }
}