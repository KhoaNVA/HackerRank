using System;
using System.Collections.Generic;
using System.Linq;

class BetweenSet
{
    /*
     * Complete the getTotalX function below.
     */
    static int GetTotalX(int[] a, int[] b)
    {
        var la = a.ToList();
        var lb = b.ToList();
        la.Sort();
        lb.Sort();

        int count = 0;

        for (int i = la.Max(); i <= lb.Min(); i++)
        {
            if (hasFactors(i, la) &&isFactorOf(i, lb))
            {
                count++;
            }
        }
        return count;
    }

    private static bool isFactorOf(int i, List<int> lb)
    {
        foreach (var item in lb)
        {
            if (item % i != 0)
            {
                return false;
            }
        }
        return true;
    }

    private static bool hasFactors(int i, List<int> la)
    {
        foreach (var item in la)
        {
            if (i % item != 0)
            {
                return false;
            }
        }
        return true;
    }

    public static void Run()
    {
        int[] a = new int[] { 3, 9, 6 };

        int[] b = new int[] { 36, 72 };

        int total = GetTotalX(a, b);

        Console.WriteLine(total);
        Console.Read();
    }
}