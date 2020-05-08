using System;
using System.Collections.Generic;
using System.Reflection;


///<summary>class</summary>
class Obj {
    ///<summary>class</summary>
    public static void Print(object myObj) {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        Console.WriteLine("{0} Properties:", t.Name);
        foreach (PropertyInfo proInfo in t.GetProperties()) {
            Console.WriteLine(proInfo.Name);
        }
        Console.WriteLine("{0} Methods:", t.Name);
        foreach (MethodInfo Pinfo in t.GetMethods()) {
            Console.WriteLine(Pinfo.Name);
        }
    }

}