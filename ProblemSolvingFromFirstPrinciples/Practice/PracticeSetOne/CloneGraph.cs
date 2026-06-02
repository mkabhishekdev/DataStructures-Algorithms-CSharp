using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetOne
{
    public class CloneGraph
    {
        public GraphNode CloneImpl(GraphNode node)
        {
            if(node == null)
            {
                return node;
            }

            Dictionary<GraphNode,GraphNode> map = new Dictionary<GraphNode, GraphNode>();
            Queue<GraphNode> myQueue = new Queue<GraphNode>();
            GraphNode newNode = new GraphNode();

            newNode.val = node.val;
            map.Add(node, newNode);

            myQueue.Enqueue(node);

            while(myQueue.Count > 0)
            {
                int size = myQueue.Count;

                while(size-- > 0)
                {
                    GraphNode originalNode = myQueue.Dequeue();
                    foreach(GraphNode child in originalNode.neighbors)
                    {
                        if(!map.ContainsKey(child))
                        {
                            GraphNode newChild = new GraphNode();
                            newChild.val = child.val;
                            myQueue.Enqueue(child);
                            map.Add(child, newChild);
                        }
                        GraphNode newListNode = map[originalNode];
                        newListNode.neighbors.Add(map[child]);
                    }
                    
                }
            }
            return map[node];
        }
    }
}