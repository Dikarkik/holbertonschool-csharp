using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        if (aQueue == null)
            aQueue = new Queue<string>();

        Console.WriteLine($"Number of items: {aQueue.Count}");

        if (aQueue.Count > 0)
            Console.WriteLine($"First item: {aQueue.Peek()}");
        else
            Console.WriteLine("Queue is empty");

        if (newItem != null)
            aQueue.Enqueue(newItem);

        if (search != null)
        {
            Console.WriteLine($"Queue contains \"{search}\": {aQueue.Contains(search)}");

            while (aQueue.Contains(search))
                aQueue.Dequeue();
        }

        return aQueue;
    }
}
