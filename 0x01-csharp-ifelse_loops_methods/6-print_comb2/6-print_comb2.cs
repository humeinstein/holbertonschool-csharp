using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int comma = 0;
            int num2 = 0;
            for (int num1 = 0; num1 < 9; num1++) {
                for (num2 = num1 + 1; num2 < 10; num2++) {
                    if (comma == 1) {
                        Console.Write(", ");}
                    comma = 1;
                    Console.Write(String.Format("{0}{1}", num1, num2));
            }
        }
            Console.Write("\n");
        }
    }
}
