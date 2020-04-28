using System;
using System.Collections.Generic;


class List {

    public static int SafePrint(List<int> myList, int n) {

        int amount = 0;
        try {
            for (int iter = 0; iter < n; iter++) {
                Console.WriteLine(myList[iter]);
                amount++;
            }
            return amount;
        }
        catch {
            return amount;
        }
    }
}