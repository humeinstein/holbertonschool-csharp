using System;
using System.Collections.Generic;

class List {
    public static List<int> DifferentElements(List<int> list1, List<int> list2) {


        List<int> new1 = list1.FindAll(elements => !list2.Contains(elements));
        List<int> new2 = list2.FindAll(elements => !list1.Contains(elements));

        new1.AddRange(new2);
        new1.Sort();
        return (new1);
    }
}
