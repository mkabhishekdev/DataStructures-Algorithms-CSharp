using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProblemSolvingFromFirstPrinciples.Heap;

/*
REFERRED APPROACH:
Use HEAP(Priority Queue in .NET)
It repeatedly:
Takes the smallest node from heap
Attaches it to the result list
Pushes that node’s next into heap

🧩 Example Setup

Suppose we have:
List1: 1 → 4 → 7
List2: 2 → 5 → 8
List3: 3 → 6 → 9

Initially we push first nodes into heap:

Heap contains: [1, 2, 3]
🏗 Step 0 — Before Loop
ListNode dummy = new ListNode(0);
ListNode current = dummy;

Visually:

dummy (0)
   |
   v
 null

current points to dummy.

Think of dummy as a starter anchor.

🔁 Iteration 1
Heap:
[1, 2, 3]
Dequeue smallest:
node = 1
Attach to result:
current.next = node;
current = current.next;

Now visually:

dummy → 1
           current

Now push 1.next (which is 4) into heap.

Heap becomes:
[2, 3, 4]
🔁 Iteration 2

Heap:

[2, 3, 4]

Dequeue → 2

Attach:

dummy → 1 → 2
                current

Push 2.next (5)

Heap:

[3, 4, 5]
🔁 Iteration 3

Dequeue → 3

dummy → 1 → 2 → 3
                       current

Push 3.next (6)

Heap:

[4, 5, 6]
🔁 Iteration 4

Dequeue → 4

dummy → 1 → 2 → 3 → 4
                               current

Push 4.next (7)

Heap:

[5, 6, 7]
🔥 Pattern You Should Notice

At any moment:

Heap holds one active node per list

Result list grows in sorted order

We never compare all nodes

We only compare k candidates

📌 Why Dummy Node?

Without dummy:

You’d need special logic for:

First insertion

Head initialization

Dummy simplifies everything.

At the end:

return dummy.next;

We skip the fake 0.

🎯 Key Mental Model

Think of it like:

Heap = k pipelines
Result = final sorted conveyor belt

Each time you:

Pick smallest pipeline output

Move that pipeline forward

Keep going until all empty

⚡ Very Important Insight

This line is the magic:

if (node.next != null)
    pq.Enqueue(node.next, node.next.val);

This ensures:

Each list contributes one candidate at a time.

Without this, heap would dry up.

🧠 Complexity Intuition (Visual Thinking)

If:

k = 3

N = 9

At every step heap size ≤ 3

So each operation costs:

log(3) ≈ constant

That’s why it becomes O(N log k).

*/

/*
Time Complexity: O(Nlogk)
Space Complexity: O(k), where k = number of linked lists and N = total number of nodes across all lists
*/

namespace ProblemSolvingFromFirstPrinciples.Heap.YourTHINKINGWork
{
    public class MergeKLists
    {
        public ListNode MergeKListsImpl(ListNode[] lists)
        {
            if((lists == null) || (lists.Length == 0))
            {
                return null;
            }

            PriorityQueue<ListNode,int> pq = new PriorityQueue<ListNode, int>();

            foreach(var indvList in lists)
            {
                if(indvList != null)
                {
                    pq.Enqueue(indvList, indvList.val); 
                }
            }

            ListNode dummy = new ListNode(0);
            ListNode current = dummy;
            
            while(pq.Count > 0)
            {
                ListNode node = pq.Dequeue();
                current.next = node;
                current = current.next;

                if(node.next != null)
                {
                    pq.Enqueue(node.next, node.next.val);
                }
            }

            return dummy.next;

        }
    }
}

// If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
/* FAILED APPROACH & WHY?
 - Thought of using Merge sort on these list of linked lists
 - It can be used & is the right direction
 - But Heap(priority queue) is conceptually more simple to apply -> so decided to go with that
*/ 
