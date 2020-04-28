using System;
using System.Collections.Generic;

class LList {

    public static int GetNode(LinkedList<int> myLList, int n) {

        int inter = 0;
        foreach (var item in myLList)
        {
            if (iter == n) { return item; }
            iter += 1;
            
        }
        return 0;
    }
}