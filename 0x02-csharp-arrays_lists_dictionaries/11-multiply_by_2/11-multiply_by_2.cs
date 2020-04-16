using System;
using System.Collections.Generic;

class Dictionary {

    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict) {
        
        Dictionary<string, int> byTwo = new Dictionary<string, int>();

        foreach (var valueKP in myDict) { byTwo.Add(valueKP.Key, (valueKP.Value * 2)); }
        return (byTwo);
    }
}