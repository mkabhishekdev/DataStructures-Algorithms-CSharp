using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Trees.YourTHINKINGWork
{
    public class SerializeDeserializeBT
    {
        /*
        MY APPROACH (THINK/CODE):
        1. For serializing
            - root of a tree is given
            - do preorder traversal on the tree
            - save the preordered traversal values into a queue
            - convert the int[] to string and return
        2. For deserializing
            - take the input string -> convert it into a int[]
            - from the int[] -> build the tree using preorder traversal

        */

        /*
        Any Optimization question while thinking through?/Any already learnt pattern you can remember?

        */

        /*
        Time Complexity:
        Space Complexity:
        */

        public string Serialize(TreeNode root)
        {

            List<string> result = new List<string>();
            PreOrderTraversal(root, result);
            string myRes = string.Join(",",result);
            return myRes;
        }

        public void PreOrderTraversal(TreeNode node, List<string> result)
        {
            if(node == null)
            {
                result.Add("null");
                return;       
            }
            
            result.Add(node.val.ToString());
            PreOrderTraversal(node.left, result);
            PreOrderTraversal(node.right, result);
        }

        public TreeNode DeSerialize(string data) //1,2,null,null,3,4,null,null,5,null,null
        {
            if(string.IsNullOrEmpty(data))
            {
                return null;
            }

            String[] myTreeArray = data.Split(',');
            int index = 0;

            return BuildingTreeImpl(myTreeArray, ref index);
        }

        private TreeNode BuildingTreeImpl(string[] input, ref int index)
        {
            if(input[index] == "null")
            {
                index++;
                return null;
            }

            TreeNode node = new TreeNode(int.Parse(input[index]));
            index++;

            node.left = BuildingTreeImpl(input, ref index);
            node.right = BuildingTreeImpl(input, ref index);

            return node;
        }
    }
}

    // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY? (preorder idea right, but tree traversal logic flawed)
             1. For serializing
            - root of a tree is given
            - do preorder traversal on the tree
            - save the preordered traversal values into a queue
            - convert the int[] to string and return
        2. For deserializing
            - take the input string -> convert it into a int[]
            - from the int[] -> build the tree using preorder traversal
       
        */ 
        /* CODE:
        

        */