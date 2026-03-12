using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Trees
{
   /*
   1. BuildTree from level-order array
   ex: [3,9,20,32,45,15,7]
   2. PrintTree (level order or simple traversal)
   */
    public static class TreeBuilderHelper
    {
        public static TreeNode BuildTree(int?[] input) // to handle null in the input
        {
            return BuildingTree(input, 0);
        }

        private static TreeNode BuildingTree(int?[] input, int index)
        {
            if(index >= input.Length || input[index] == null)
            {
                return null;
            }

            TreeNode node = new TreeNode(input[index].Value);

            node.left = BuildingTree(input, 2*index + 1);
            node.right = BuildingTree(input, 2*index + 2);

            return node;
        }

        public static void PrintTree(TreeNode root)
        {
            if(root == null)
            {
                return;
            }

            Queue<TreeNode> printTree = new Queue<TreeNode>();
            printTree.Enqueue(root);

            while(printTree.Count > 0)
            {   
                int levelSize = printTree.Count;
                
                for(int i = 0; i < levelSize; i++)
                {
                    TreeNode removedElement = printTree.Dequeue();
                    Console.Write(removedElement.val + " ");

                    if(removedElement.left != null)
                    {
                        printTree.Enqueue(removedElement.left);
                    }

                    if(removedElement.right != null)
                    {
                        printTree.Enqueue(removedElement.right);
                    }
                }
                Console.WriteLine(); // move to next level
            }
          

        }
    }
}