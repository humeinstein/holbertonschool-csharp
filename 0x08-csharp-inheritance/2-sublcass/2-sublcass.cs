using System;

///<summary>class</summary>
class Obj {

    ///<summary>bool - sublass</summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType) {
        return derivedType.IsSubclassOf(baseType);
    }
}
