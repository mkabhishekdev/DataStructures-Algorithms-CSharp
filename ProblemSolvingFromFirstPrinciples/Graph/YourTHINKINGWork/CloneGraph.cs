using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProblemSolvingFromFirstPrinciples.Graph;

/* REFERRED APPROACH
🧩 Imagine This Graph

Suppose the graph is:

    1
   / \
  2---3


Meaning:

1 connects to 2 and 3

2 connects to 1 and 3

3 connects to 1 and 2

It has a cycle.

🎯 Goal

You are given reference to node 1.

You must create a completely new graph with same structure.

Original objects:

1 (memory A)
2 (memory B)
3 (memory C)


Cloned objects must be:

1' (new memory X)
2' (new memory Y)
3' (new memory Z)


No clone should point to original.

🚨 Why Naive Recursion Fails

If you just do:

Clone(1)
  -> Clone(2)
      -> Clone(1)
          -> Clone(2)
              -> infinite...


You keep bouncing between 1 and 2 forever.

That’s the problem.

🧠 The Trick: Use a Map

We keep a dictionary:

Original Node  ->  Cloned Node


Like:

1  ->  1'
2  ->  2'
3  ->  3'


This helps us remember:

“Have I already cloned this node?”

🔎 Now Let’s Walk Step-by-Step Visually
STEP 1: Start with Node 1

We call:

DFS(1)


Map is empty:

{}


1 not in map → create clone:

1 -> 1'


Map becomes:

{
  1 : 1'
}


Now process neighbors of 1 → [2, 3]

STEP 2: Visit Neighbor 2

Call:

DFS(2)


2 not in map → create clone:

2 -> 2'


Map now:

{
  1 : 1',
  2 : 2'
}


Now process neighbors of 2 → [1, 3]

2 sees neighbor 1

Call:

DFS(1)


But 1 is already in map!

So we immediately return:

1'


We DO NOT clone again.

This prevents infinite loop.

Now connect:

2' → 1'

2 sees neighbor 3

Call:

DFS(3)


3 not in map → create clone:

3 -> 3'


Map becomes:

{
  1 : 1',
  2 : 2',
  3 : 3'
}


Now process neighbors of 3 → [1, 2]

3 sees neighbor 1

Already in map → return 1'

Connect:

3' → 1'

3 sees neighbor 2

Already in map → return 2'

Connect:

3' → 2'


Done with 3.

Return 3'.

Now connect:

2' → 3'


Done with 2.

Return 2'.

Now connect:

1' → 2'

STEP 3: Back to Node 1 → Next Neighbor 3

Call:

DFS(3)


Already in map → return 3'

Connect:

1' → 3'


Done.

✅ Final Cloned Graph
    1'
   /  \
  2'---3'


Structure identical.

But memory is different.

🔥 The Entire Algorithm in One Sentence

“Before cloning a node, check if it’s already cloned. If yes, reuse it. If not, create it and then clone its neighbors.”

🎨 Super Simple Real-Life Analogy

Imagine you're rebuilding a city using a blueprint.

Each house connects to other houses.

If you:

Rebuild house A

Then go to house B

Then from B try to rebuild A again

You must NOT rebuild A again.

So you keep a notebook:

Old House → New House


Whenever you see a house:

If in notebook → reuse new house

If not → build and write in notebook

That notebook is your Dictionary.
*/

/*
Let:
V = number of vertices (nodes)
E = number of edges

Time Complexity: O(V+E)
Space Complexity: O(V)
*/

namespace ProblemSolvingFromFirstPrinciples.Graph.YourTHINKINGWork
{
    public class CloneGraph
    {
        Dictionary<Node,Node> map = new Dictionary<Node, Node>();

        public Node CloneGraphImpl(Node node)
        {

            if(node == null)
            {
                return null;
            }

            Node curr = new Node(node.val);
            map.Add(node, curr);

            foreach(var neighborNode in node.neighbors)
            {
                if(!map.ContainsKey(neighborNode))
                {
                    CloneGraphImpl(neighborNode); // does not exist so add to the dictionary
                }
                curr.neighbors.Add(map[neighborNode]); //exists, so get into from the Dictionary and add it to the list
                                                         // of neighbors
            }

            return curr;
        }
    }
}