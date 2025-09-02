/*
2. Find Intersection of Two Lists
Problem:
Given two lists of integers, find all common elements (intersection).

Input:
List<int> list1 = new List<int> { 1, 2, 3, 4 };
List<int> list2 = new List<int> { 3, 4, 5, 6 };

Expected Output:
3 4

* Instead of using nested for loops for doing the operation in O(1) use = HashSet
Time Complexity:
Space Complexity:
*/

using System.Collections.Generic;
public class ListProblem2
{
    public List<int> IntersectionResult(List<int> list1, List<int> list2)
    {
        HashSet<int> firstList = new HashSet<int>(list1);
        HashSet<int> resultList = new HashSet<int>();

        foreach(var item in list2)
        {
            if(firstList.Contains(item))
            {
                resultList.Add(item);
            }
        }
        
        return new List<int>(resultList);
    }
}
// Time complexity: O(n+m) where n and m are sizes of the list
// Space complexity: O(n)


/*

  ListProblem2 lp2 = new ListProblem2();
        List<int> input1 = new List<int>{1,2,3,4};
        List<int> input2 = new List<int>{3,4,5,6};

        List<int> store = lp2.IntersectionResult(input1, input2);

        Console.WriteLine("Common elements from the two lists are: ");
        for(int i = 0; i < store.Count; i++)
        {
            Console.WriteLine(store[i]);
        }

  Time Complexity: O(n2) or O(n*m) if n and m size of the lists are different
  Space Complexity: O(n)
*/