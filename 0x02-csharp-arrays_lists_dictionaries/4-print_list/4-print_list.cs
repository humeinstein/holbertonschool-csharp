using System;
using System.Collections.Generic;

class List {
    public static List<int> CreatePrint(int size) {
        if (size < 0) { Console.WriteLine("Size cannot be negative"); return null; }
    List<int> printList = new List<int>();
    for (int iter = 0; iter < size; iter++) { printList.Add(iter); }
    Console.WriteLine(string.Join(" ", printList));
    return printList;

    }
}