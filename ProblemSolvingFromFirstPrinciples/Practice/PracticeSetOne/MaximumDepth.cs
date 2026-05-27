using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLabCodeRepo.Interview
{
    public class MaximumDepth
    {
        public int MaximumDepthImpl(TreeNode head)
        {
            if(head == null)
            {
                return 0;
            }

            TreeNode curr = head;
            Queue<TreeNode> myQueue = new Queue<TreeNode>();
            int depth = 0;

            myQueue.Enqueue(curr);
            TreeNode presentNode = new TreeNode(0);

            while(myQueue.Count > 0)
            {
                int levelSize = myQueue.Count; // this gets the entire elements in that level,
                                               //   now operate on that
                
                for(int i = 0; i < levelSize; i++)
                {
                    presentNode = myQueue.Dequeue();

                    if(presentNode.left != null)
                    {
                        myQueue.Enqueue(presentNode.left);
                    }
                    if(presentNode.right != null)
                    {
                        myQueue.Enqueue(presentNode.right);
                    }
                }
                depth++;
            }

            return depth;
        }
    }
}