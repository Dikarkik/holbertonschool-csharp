using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> commonElements = new List<int>();

        if (list1 == null || list2 == null)
            return commonElements;

        list1.Sort();

        foreach (int n in list1)
        {
            if (list2.Contains(n))
                commonElements.Add(n);
        }

        return commonElements;
    }
}
