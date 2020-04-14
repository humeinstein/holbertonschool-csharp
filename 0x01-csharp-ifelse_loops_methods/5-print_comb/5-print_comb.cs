using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
		int num = 0;

		while (num < 100) {
		      Console.WriteLine(String.Format("{0:d2}", num));
		      num++;
		      }
        }
    }
}
