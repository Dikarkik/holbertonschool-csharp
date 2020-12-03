using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        if (myLList == null || myLList.First == null)
            return 0;

        LinkedListNode<int> current = myLList.First;
        int sum = 0;

        while (current != null)
        {
            sum += current.Value;
            current = current.Next;
        }

        return sum;
    }
}
