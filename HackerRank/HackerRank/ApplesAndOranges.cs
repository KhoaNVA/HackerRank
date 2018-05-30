using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class ApplesAndOranges
    {
        // Complete the countApplesAndOranges function below.
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            for (int i = 0; i < apples.Length; i++)
            {
                apples[i] = apples[i] + a;
            }
            for (int i = 0; i < oranges.Length; i++)
            {
                oranges[i] = oranges[i] + b;
            }

            var appleCount = from k in apples
                             where k >= s & k <= t
                             select k;
            var orangeCount = from k in oranges
                              where k >= s & k <= t
                              select k;
            Console.WriteLine(appleCount.Count());
            Console.WriteLine(orangeCount.Count());
            Console.Read();
        }

        public static void Run()
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
