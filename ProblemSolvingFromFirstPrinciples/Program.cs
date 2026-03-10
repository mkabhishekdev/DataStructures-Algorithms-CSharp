using System;
using ProblemSolvingFromFirstPrinciples.InterestingProblems;
using ProblemSolvingFromFirstPrinciples.Trees.YourTHINKINGWork;
using ProblemSolvingFromFirstPrinciples.Trees;
using ProblemSolvingFromFirstPrinciples.Graph.YourTHINKINGWork;

class Program
{
    static void Main(string[] args)
    {
        CourseSchedule_KahnesAlgorithm_TopologicalSort cs = new CourseSchedule_KahnesAlgorithm_TopologicalSort();

        int numCourses = 2;
        int[][] prerequisites = new int[][]
        {
            new int[] {1,0}
        };

        Console.WriteLine(cs.CanFinish(numCourses, prerequisites));
        

        
    }
}
