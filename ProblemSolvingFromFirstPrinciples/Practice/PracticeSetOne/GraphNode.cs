using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLabCodeRepo.Interview
{
    public class GraphNode
    {
        public int val;
        public List<GraphNode> neighbors;

        public GraphNode()
        {
            val = 0;
            neighbors = new List<GraphNode>();
        }

        public GraphNode(int x)
        {
            val = x;
            neighbors = new List<GraphNode>();
        }
        
        public GraphNode(int x, List<GraphNode> _neighbors)
        {
            val = x;
            neighbors = _neighbors;
        }

    }
}