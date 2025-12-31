/*

3. Reverse a List Manually
Problem:
Reverse the elements of a list without using built-in Reverse() method.

Input:
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

Expected Output:
5 4 3 2 1

Time Complexity: O(n)
Space Complexity: O(n)
*/
public class ListProblem3
{
    public List<int> Reverse(List<int> input)
    {
        List<int> result = new List<int>();

        for(int i = input.Count - 1; i >=0 ; i--)
        {
            result.Add(input[i]);
        } 

        return result;
    }
}

/*
  ListProblem3 lp3 = new ListProblem3();
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<int> printList = lp3.Reverse(numbers);

        Console.WriteLine("Reversed linked list is: ");
        for(int i = 0; i < printList.Count; i++)
        {
            Console.WriteLine(printList[i]);
        }
*/