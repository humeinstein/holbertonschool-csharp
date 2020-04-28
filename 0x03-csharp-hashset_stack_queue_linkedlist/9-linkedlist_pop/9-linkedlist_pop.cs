using System;
using System.Collections.Generic;


class LList {
    public static int Pop(LinkedList<int> myLList) {

        if (myLList.Count < 1) { return 0; }

        LinkedListNode<int> firstN = myLList.First;
        myLList.RemoveFirst();
        return firstN.Value;
    }
}