﻿using System;

class Dictionary {
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value) {
        myDict[key] = value;
        return myDict;
    }
}
