using System;
using System.Collections.Generic;


///<summary></summary>
class Obj {
    ///<summary></summary>
    public static bool IsInstanceOfArray(object obj) {
        return (typeof(Array).IsInstanceOfType(obj));
    }
}
