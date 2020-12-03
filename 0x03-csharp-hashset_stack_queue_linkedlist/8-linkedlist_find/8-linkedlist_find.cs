using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        if (myLList == null)
            return -1;

        LinkedListNode<int> current = myLList.First;
        int index = 0;

        while (current != null)
        {
            if (current.Value != value)
                index++;
            else
                return index;

            current = current.Next;
        }

        return -1;
    }
}
