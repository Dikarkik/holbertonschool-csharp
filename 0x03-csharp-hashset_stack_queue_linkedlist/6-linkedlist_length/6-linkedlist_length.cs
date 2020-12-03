using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        if (myLList == null)
            return 0;

        LinkedListNode<int> current = myLList.First;
        int count = 0;

        while (current != null)
        {
            count++;
            current = current.Next;
        }

        return count;
    }
}
