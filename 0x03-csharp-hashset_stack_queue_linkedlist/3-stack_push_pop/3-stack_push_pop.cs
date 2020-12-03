using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        if (aStack == null)
            aStack = new Stack<string>();

        Console.WriteLine($"Number of items: {aStack.Count}");

        if (aStack.Count > 0)
            Console.WriteLine($"Top item: {aStack.Peek()}");
        else
            Console.WriteLine("Stack is empty");

        if (search != null)
        {
            Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");

            while (aStack.Contains(search))
                aStack.Pop();
        }

        if (newItem != null)
            aStack.Push(newItem);

        return aStack;
    }
}
