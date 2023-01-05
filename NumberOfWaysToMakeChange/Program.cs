using System;

namespace NumberOfWaysToMakeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int[] denoms = new int[] { 1, 5 };

            Console.WriteLine($"Array :{ String.Join<int>(',', denoms)} , n : { n }");

            var output = NumberOfWaysToMakeChange(n, denoms);
            Console.WriteLine($"Number Of Ways To Make Change is: { output } ");
        }

        // O(nd) Time, O(n) Space
        public static int NumberOfWaysToMakeChange(int n, int[] denoms)
        {
            int[] memos = new int[n + 1];
            memos[0] = 1;

            foreach (var coin in denoms)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i >= coin)
                        memos[i] += memos[i - coin]; 
                }
            }

            return memos[n];
        }
    }
}
