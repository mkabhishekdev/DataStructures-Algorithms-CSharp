using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Trees.YourTHINKINGWork
{
    /* Referred Approach
    1. Always on questions on BST, first think to analyze on his root > left and root < right
       i.e left < root < right
    2. You need to utilize this above special property if a BST. This is in a way, a sorted tree is
       being given to you. Always ask if the tree you are operating upon is a binary search tree or
       binary tree
    3. than for LCA problem, find out if the given p and q treenodes are on the left , right or in the root
       position using recursion
    */

    /* any optimization later

    */

    /* time complexity: O(h), where h is the height of the tree
    space complexity: O(1)
    */
    public class LowestCommonAncestor
    {
        public TreeNode LowestCommonAncestorImpl(TreeNode root, TreeNode p, TreeNode q)
        {
            if((p.val < root.val) && (q.val < root.val))
            {
                return LowestCommonAncestorImpl(root.left, p, q);
            }

            if((p.val > root.val) && (q.val > root.val))
            {
                return LowestCommonAncestorImpl(root.right, p, q);
            }

            return root;
        }
    }
}

     /* FAILED APPROACH & WHY? (this may work for Binary tree but overcomplicated for BST)
    1. traverse through the nodes in the root tree to reach the 'p' node in root and store it 
       in a list1
    2. similarly, traverse through the nodes in the root tree to reach the 'q' node in root and store
       it in a list2
    3. pick the common element in both the list1 and list2
    4. that is the common ancestor for p and q
       
        */ 
        /* CODE:
           TreeNode temp = root;
            List<int> storeForP = new List<int>();
            List<int> storeForQ = new List<int>();
            
            if(temp == p)
            {
                storeForP.Add(p.val);
            } 
            if(temp == q)
            {
                storeForQ.Add(q.val);
            }

            LowestCommonAncestorImpl(root.left, p, q);
            LowestCommonAncestorImpl(root.right, p, q);
            
            for(int i = 0; i < storeForP.Count; i++)
            {
                for(int j = 0; j < storeForQ.Count; j++)
                {
                    if(storeForQ[j] == storeForQ[i])
                    {
                        return new TreeNode(storeForQ[j]);            
                    }
                }
            }

            return null;

        */