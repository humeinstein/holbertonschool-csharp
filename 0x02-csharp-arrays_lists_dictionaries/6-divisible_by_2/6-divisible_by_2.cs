using System;
using System.Collections.Generic;

class List {
    public static List<bool> DivisibleBy2(List<int> myList) {

    
        List<bool> byTwoList = new List<bool>();

        foreach (var num in myList)
        {
            if (num % 2 == 0) { byTwoList.Add(true); }
            else { byTwoList.Add(false); }
        }

        return byTwoList;
    }
}