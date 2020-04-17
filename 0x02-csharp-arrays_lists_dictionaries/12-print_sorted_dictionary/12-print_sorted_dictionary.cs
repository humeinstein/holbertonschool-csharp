using System;
using System.Collections.Generic;

class Dictionary {

    public static void PrintSorted(Dictionary<string, string> myDict) {
        SortedList<string, string> sortList = new SortedList<string, string>(myDict);

        foreach (var keyVP in sortList.Keys) { Console.WriteLine("{0}:  {1}", keyVP, sortList[keyVP]); }
    }
}