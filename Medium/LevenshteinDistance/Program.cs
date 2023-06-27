using System;

namespace LevenshteinDistance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abc", str2 = "yabd";
            Console.WriteLine($"Levenshtein Distance for <<{str1}>> and <<{str2}>> is {LevenshteinDistance(str1,str2)}");
        }

        //Time O(nm) , Space O(n)
        public static int LevenshteinDistance(string str1, string str2)
        {
            string small = str1.Length < str2.Length ? str1 : str2;
            string large = str1.Length >= str2.Length ? str1 : str2;

            int[] evenEdits = new int[small.Length + 1];
            int[] oddEdits = new int[small.Length + 1];

            for (int i = 0; i < small.Length + 1; i++)
            {
                evenEdits[i] = i;
            }

            int[] currentRow;
            int[] previousRow;
            for (int r = 1; r < large.Length + 1; r++)
            {
                currentRow = evenEdits;
                previousRow = oddEdits;
                if (r % 2 == 1)
                {
                    currentRow = oddEdits;
                    previousRow = evenEdits;
                }
                currentRow[0] = r;
                for (int c = 1; c < small.Length + 1; c++)
                {
                    if (large[r - 1] == small[c - 1])
                        currentRow[c] = previousRow[c - 1];
                    else
                        currentRow[c] = 1 + Math.Min(currentRow[c - 1], Math.Min(previousRow[c], previousRow[c - 1]));

                }
            }

            return large.Length % 2 == 0 ? evenEdits[small.Length] : oddEdits[small.Length];
        }

        //Time O(nm) , Space O(nm)
        //public static int LevenshteinDistance(string str1, string str2)
        //{
        //    var twoDADistances = new int[str1.Length + 1, str2.Length + 1];
        //    for (int i = 0; i <= str1.Length; i++)
        //    {
        //        for (int j = 0; j <= str2.Length; j++)
        //        {
        //            if (i == 0)
        //            {
        //                twoDADistances[i, j] = j;
        //            }
        //            else if (j == 0)
        //            {
        //                twoDADistances[i, j] = i;
        //            }
        //            else
        //            {

        //                if (str1[i - 1] == str2[j - 1])
        //                {
        //                    twoDADistances[i, j] = twoDADistances[i - 1, j - 1];
        //                }
        //                else
        //                {
        //                    twoDADistances[i, j] = Math.Min(twoDADistances[i - 1, j - 1], Math.Min(twoDADistances[i, j - 1], twoDADistances[i - 1, j])) + 1;
        //                }
        //            }
        //        }
        //    }
        //    return twoDADistances[str1.Length, str2.Length];
        //}
    }
}
