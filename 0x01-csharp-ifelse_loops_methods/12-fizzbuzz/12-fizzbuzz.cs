using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int iter = 1; iter <= 100; iter++) {
                if (iter % 5 == 0) { Console.Write("Buzz"); }
                else if (iter % 15 == 0) { Console.Write("FizzBuzz"); }
                else if (iter % 3 == 0) { Console.Write("Fizz"); }
                else { Console.Write(iter); }
                Console.Write(" ");
            }
            Console.Write("\n");
        }
    }
}
