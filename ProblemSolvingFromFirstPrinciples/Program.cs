using System;
using ProblemSolvingFromFirstPrinciples.InterestingProblems;
using ProblemSolvingFromFirstPrinciples.Trees.YourTHINKINGWork;
using ProductCodingPractice.BinaryTrees;

class Program
{
    static void Main(string[] args)
    {
        LevelOrder lo = new LevelOrder();

        TreeNode root = new TreeNode(3);
        root.left = new TreeNode(9);
        root.right = new TreeNode(20);
        root.right.left = new TreeNode(15);
        root.right.right = new TreeNode(7);

        Console.WriteLine(lo.LevelOrderImpl(root));

        
    }
}
