using System;

namespace MaxSubsetSumNoAdjacent
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 75, 105, 120, 75, 90, 135 };
            int[] array2 = { 4, 3, 5, 200, 5, 3 }; //207
            int[] array3 = { 30, 25, 50, 55, 100, 120 }; //205

            Console.WriteLine($"And the result is : { MaxSubsetSumNoAdjacent(array3) }");
        }

        public static int MaxSubsetSumNoAdjacent(int[] array)
        {
            if (array.Length < 1)
            {
                return 0;
            }
            int[] maxex = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    maxex[i] = array[i];
                    continue;
                }
                else if (i == 1)
                {
                    maxex[i] = Math.Max(array[i], array[i - 1]);
                    continue;
                }

                maxex[i] = Math.Max(maxex[i - 1], maxex[i - 2] + array[i]);
            }

            return maxex[array.Length - 1];
        }
    }
}
