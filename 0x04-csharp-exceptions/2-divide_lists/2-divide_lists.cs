using System;
using System.Collections.Generic;

class List {
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength) {

    int current = 0;
    List<int> dividedList = new List<int>();

    foreach (var item in list1) {

        try { dividedList.Add(item / list2[current]); 
                current++ ; }
        catch (DivideByZeroException) { Console.WriteLine("Cannot divide by zero");
                                            dividedList.Add(0);
                                            current++ ; }
        catch (ArgumentOutOfRangeException) { Console.WriteLine("Out of range"); }
                                            
    }
    return dividedList;
    }
}