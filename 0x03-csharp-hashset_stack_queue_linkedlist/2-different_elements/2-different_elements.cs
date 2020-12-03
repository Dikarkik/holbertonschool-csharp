using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> differentElements = new List<int>();
        
        if (list1 == null || list2 == null)
            return null;

        foreach (int n in list1)
        {
            if (!list2.Contains(n))
                differentElements.Add(n);
        }

        foreach (int n in list2)
        {
            if (!list1.Contains(n))
                differentElements.Add(n);
        }

        differentElements.Sort();
        return differentElements;
    }
}
