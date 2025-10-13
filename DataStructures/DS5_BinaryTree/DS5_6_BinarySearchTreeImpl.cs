using System;
using System.Xml;
using DataStructures.BinaryTree;

public class DS5_6_BinarySearchTreeImpl
{
    public bool BinarySearchTree(TreeNode root, int Key)
    {
        if (root == null)
        {
            Console.WriteLine("Key not found in the BST");
            return false;
        }

        if (root.data == Key)
        {
            Console.WriteLine("Key found in the BST");
            return true;
        }

        if (Key > root.data)
        {
            BinarySearchTree(root.right, Key);
        }
        else if (Key < root.data)
        {
            BinarySearchTree(root.left, Key);
        }

        return false;
    }

}