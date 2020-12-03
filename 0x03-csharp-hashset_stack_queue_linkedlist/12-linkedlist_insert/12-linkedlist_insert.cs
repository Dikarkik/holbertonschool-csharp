using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        if (myLList == null)
            myLList = new LinkedList<int>();

        if (myLList.First == null)
            return myLList.AddLast(n);

        LinkedListNode<int> current = myLList.First;

        for (int i = 0; i < myLList.Count; i++)
        {
            if (n < current.Value)
                return myLList.AddBefore(current, n);

            current = current.Next;
        }

        // if the new node must be at the end
        return myLList.AddAfter(myLList.Last, n);
    }
}
