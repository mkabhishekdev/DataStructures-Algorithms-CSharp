// Implementing stack using array
/*
Below operations:
1. Push(int data)
2. Pop()
3. Peek()
4. Display() 
*/

public class DS3_1_StackUsingArrayImpl
{

    int[] storeLikeStack = new int[10];
    int top = -1;

    public void Push(int data)
    {
        if (top != (storeLikeStack.Length - 1))
        {
            top++;
            storeLikeStack[top] = data;
        }
        else
        {
            Console.WriteLine("Stack Overflow!");
        }
    }

    public void Pop()
    {
        if (top != -1)
        {
            storeLikeStack[top] = storeLikeStack[top--];
        }
    }

    public int Peek()
    {
        return storeLikeStack[top];
    }

    public void DisplayStack()
    {
        Console.WriteLine("The Stack is: ");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(storeLikeStack[i]);
        }
    }
}