using System;

class KangarooRace
{

    // Complete the kangaroo function below.
    static string Kangaroo(int x1, int v1, int x2, int v2)
    {
        while (x1 != x2)
        {
            x1 = x1 + v1;
            x2 = x2 + v2;
            if (v1 >= v2)
            {
                if (x1 > x2) return "NO";
            }
            else
            {
                if (x1 < x2) return "NO";
            }
        }
        return "YES";
    }

    public static void Run()
    {
        string[] x1V1X2V2 = new string[] { "0", "2", "5", "3" };

        int x1 = Convert.ToInt32(x1V1X2V2[0]);

        int v1 = Convert.ToInt32(x1V1X2V2[1]);

        int x2 = Convert.ToInt32(x1V1X2V2[2]);

        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        string result = Kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);
        Console.Read();
    }
}