using System;

class Line {
    public static void PrintLine(int length) {
        if (length < 1) { Console.Write("\n"); }
        for (int iter = 0; iter < length; iter++) { Console.Write( "_"); }
    }
}
