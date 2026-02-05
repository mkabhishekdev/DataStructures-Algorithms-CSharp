using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCodingPractice.BinaryTrees;

namespace ProductCodingPractice.Trees.YourTHINKINGWork
{
    public class InvertTree
    {
        /*
       APPROACH I CAME UP WITH:
       1. Start from the root
       2. Use a Stack (DFS)
       3. While traversal continues:
              - Take one node
              - Swap its left and right child references
              - Add its children to the stack (if they exist)
        4. Done 
        */

        public TreeNode InvertTreeImpl(TreeNode root)
        {
            Stack<TreeNode> storage = new Stack<TreeNode>();

            if (root == null)
            {
                return null;
            }

            storage.Push(root);

            TreeNode top; 

            while (storage.Count > 0)
            {
                top = storage.Pop();
                
                TreeNode temp = top.left;
                top.left = top.right;
                top.right = temp;

                if (top.left != null)
                {
                    storage.Push(top.left);
                }
                if (top.right != null)
                {
                    storage.Push(top.right);
                }
            }

            return root;
        }
    }
}

/* FAILED APPROACH
Idea right, execution wrong
1. Create a result tree node. Point the result head with input node head. Since this will be same even after rotation. 
2. My idea is to use a Stack. 
3. Check if left node of root exists -> if yes, Push to stack 
4. Check if right node of root exists -> if yes, Push to stack 
5. Now When popping from the stack check if it contains left & right node. Than push into the stack 
6. Move the popped element to left of the result tree node, if left already occupied move that node to right
*/
