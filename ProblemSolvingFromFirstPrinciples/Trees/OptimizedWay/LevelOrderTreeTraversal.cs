using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLabCodeRepo.Interview
{
    /* My approach
    - use a queue
    - first enqueue the root to the queue
    - than check if root has left,right
    - also keep a levelTrackerCOunter to keep 
track of each level since you need to save each level
as a separate list
    - once the levelTrackerCounter is 0, it means it is a level
    - keep following above idea until queue is empty
    */
    public class LevelOrderTreeTraversal
    {
        public IList<IList<int>> LevelOrderImpl(TreeNode head)
        {
            Queue<TreeNode> myStore = new Queue<TreeNode>();
            myStore.Enqueue(head);
            
            IList<IList<int>> myResult = new List<IList<int>>();
         
            while(myStore.Count > 0)
            {
                int levelSize = myStore.Count;
                IList<int> innerRes = new List<int>();

                for(int i = 0; i < levelSize; i++)
                {
                    TreeNode presentNode = myStore.Dequeue();
                    innerRes.Add(presentNode.val);
             
                    if(presentNode.left != null)
                    {
                        myStore.Enqueue(presentNode.left);
                    }
                    if(presentNode.right != null)
                    {
                        myStore.Enqueue(presentNode.right);
                    }
                }
                myResult.Add(innerRes);
            }  

            return myResult;
        }
    }
}