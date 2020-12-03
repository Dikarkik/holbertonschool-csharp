using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        if (myList == null)
            return 0;

        HashSet<int> set = new HashSet<int>(myList);
        int sum = 0;

        foreach (int n in set)
            sum += n;

        return sum;
    }
}
