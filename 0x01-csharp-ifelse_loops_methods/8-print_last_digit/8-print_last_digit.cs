using System;

class Number {
    public static int PrintLastDigit(int number) {
        int end = 0;
        if (number < 0) { number *= -1; }
        end = number % 10;
        Console.Write(end);
        return (end);
    }
}