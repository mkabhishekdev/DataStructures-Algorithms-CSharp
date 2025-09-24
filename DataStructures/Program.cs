using System;

class Program
{
    static void Main(string[] args)
    {
        DS5_1_BinaryTreeImpl bti = new DS5_1_BinaryTreeImpl();
        int[] nodes = { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };

        Console.WriteLine("The root element is: " + bti.CreateBinaryTree(nodes).data);

    }
}