using System;
using System.Collections.Generic;

class LList {

    public static LinkedList<int> CreatePrint(int size) {

        LinkedList<int> llCollection = new LinkedList<int>();

        for (int iter = 0; iter < size; iter++) { llCollection.AddLast(iter) ; } 
        foreach (var item in llCollection) { Console.WriteLine(item) ; }
        return  llCollection;
    }
}
