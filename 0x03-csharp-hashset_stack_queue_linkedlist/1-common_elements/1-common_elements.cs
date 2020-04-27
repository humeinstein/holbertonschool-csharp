using System;
using System.Collections.Generic;

class List {
    public static List<int> CommonElements(List<int> list1, List<int> list2) {

        List<int> matching = list1.FindAll(matchedValues => list2.Contains(matchedValues));
        return matching;
    }
}
