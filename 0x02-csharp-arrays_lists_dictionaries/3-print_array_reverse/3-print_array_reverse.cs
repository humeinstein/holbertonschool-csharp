using System;

class Array {
    public static void Reverse(int[] array) {
        if (array == null) { Console.WriteLine(""); return; }
        else {
            for (int iter = array.Length - 1; iter >= 0; iter--) {
                Console.Write(array[iter]);
                if (iter != 0) { Console.Write(" "); }
            }
            Console.Write("\n");
        }
    }
}