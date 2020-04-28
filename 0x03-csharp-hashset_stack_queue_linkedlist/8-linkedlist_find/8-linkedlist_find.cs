using System;
using System.Collections.Generic;

class LList {

    public static int FindNode(LinkedList<int> myLList, int value) {

        int check = 0;
        foreach (var item in myLList)
        {
            if (item == value) { return check; }
            check += 1;

        }
        return -1;
    }
}