using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetTwo
{
    public class InvertBinaryTree
    {
        public TreeNode InvertBT(TreeNode root)
        {
            if(root == null)
            {
                return null;
            }
            
            TreeNode left = InvertBT(root.left);
            TreeNode right = InvertBT(root.right);
         
            root.left = right;
            root.right = left;
             
            return root;
        }
    }
}