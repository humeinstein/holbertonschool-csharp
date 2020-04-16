using System;

class Array {
    public static int[] CreatePrint(int size) {
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] retArray = new int[size];
        for(int iter = 0; iter < size; iter++) { retArray[iter] = iter; }

        Console.WriteLine(String.Join(" ", retArray));
        return retArray;
    }
}
