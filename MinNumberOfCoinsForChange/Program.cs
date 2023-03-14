using System;

namespace MinNumberOfCoinsForChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] denoms = new int[] { 1, 5, 10 };
            int n = 7;
            Console.WriteLine($"MinNumber Of Coins For Change : { MinNumberOfCoinsForChange(n, denoms) }");
        }

        public static int MinNumberOfCoinsForChange(int n, int[] denoms)
        {
            int number = -1;

            return number;
        }
    }
}
