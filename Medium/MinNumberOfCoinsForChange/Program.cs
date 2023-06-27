using System;

namespace MinNumberOfCoinsForChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] denoms = new int[] { 1, 5, 10 };
            int n = 7;

            #region Test case 5
            //denoms = new int[] { 2, 1 };
            //n = 3;
            #endregion
            Console.WriteLine($"MinNumber Of Coins For Change : { MinNumberOfCoinsForChange(n, denoms) }");
        }

        public static int MinNumberOfCoinsForChange(int n, int[] denoms)
        {
            int[] minWays = new int[n + 1];
            Array.Fill(minWays, Int32.MaxValue );
            minWays[0] = 0;
            foreach (int coin in denoms)
            {
                for (int i = coin; i <= n; ++i)
                {
                    minWays[i] = Math.Min(minWays[i],minWays[i - coin] + 1);
                }
            }

            return minWays[n] == int.MaxValue  ? -1 : minWays[n];
        }
    }
}
