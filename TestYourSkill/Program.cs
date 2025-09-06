using System;

class Program
{
    static void Main(string[] args)
    {
        TYS3_2_QueueUsingLinkedList tys32 = new TYS3_2_QueueUsingLinkedList();
        tys32.Enqueue(7);
        tys32.Enqueue(4);
        tys32.Enqueue(8);
        tys32.Enqueue(11);
        tys32.Enqueue(1);
        tys32.Display();
        tys32.Dequeue();
        tys32.Display();
        tys32.Peek();
                
    

    }
}

/*
    TYS3_1_LinearSearch tys31 = new TYS3_1_LinearSearch();

        int[] input = { 8, 4, 11, 7, 2, 5, 3, 9, 6 };

        tys31.LinearSearchImpl(input, 100);
*/