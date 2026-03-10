using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Graph.YourTHINKINGWork
{

    /*
    REFERRED APPROACH:
    Kahnes Algorithm/Topological sorting
    1. You use BFS(queue) and a Dictionary kind of operating int[]
    2. Keep popping out of the queue and decrement the count value from the Dictionary
    3. If count value equals number of courses return true or else return false
    */

    /*
    Any Optimization question while thinking through?/Any already learnt pattern you can remember?

    */

    /*
    Time Complexity: O(n)
    Space Complexity: O(n)
    */

    // DEBUG: DRY-RUN THIS
    
    public class CourseSchedule_KahnesAlgorithm_TopologicalSort
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            List<List<int>> graph = new List<List<int>>();
            int[] inDegree = new int[numCourses];
            for(int i = 0; i < numCourses; i++)
            {
                graph.Add(new List<int>());
            }

            foreach(int[] pre in prerequisites)
            {
                graph[pre[1]].Add(pre[0]);
                inDegree[pre[0]]++;
            }

            Queue<int> queue = new Queue<int>();
            for(int i = 0; i < numCourses; i++)
            {
                if(inDegree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            int count = 0;
            while(queue.Count > 0)
            {
                int curr = queue.Dequeue();
                count++;
                foreach(int next in graph[curr])
                {
                    inDegree[next]--;
                    if(inDegree[next] == 0)
                    {
                        queue.Enqueue(next);
                    }
                }
            }

            return count == numCourses;
        }
    }
     
}

 // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
    /* FAILED APPROACH & WHY?(Cycle intuition was right, logic after that is wrong)
    1. If there is a cycle in the graph, it is impossible -> false
    2. If there is no cycle in the graph, it is possible -> true
    3. Issue with how prerequisite is being passed? if we need [] why the input is [][]?
    4. Based on the numberofcourses, save all the numbers starting from 0 to (numberOfCourses - 1)
    5. Now from the prerequisite, identify if there is any repetition in the individual array elements,
       if there is a repetition of the combination than there is a cycle, if no repetition of any combination
       in the prerequisite than there is no cycle and hence true
       
    */ 
    /* CODE:
        

    */