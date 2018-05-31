using System;

class BirthdayChoc
{

    // Complete the solve function below.
    static int Solve(int[] s, int d, int m)
    {
        if (m <= s.Length)
        {
            int c = 0;
            for (int i = 0; i + m - 1 < s.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < m+i; j++)
                {
                    sum = sum + s[j];
                }
                if (sum == d)
                {
                    c++;
                }
            }
            return c;
        }
        return 0;
    }

    public static void run()
    {
        //int[] s = new int[] { 1, 2, 1, 3, 2 };
        int[] s = new int[] { 4 };
        
        string[] dm = new string[] { "4", "1" };

        int d = Convert.ToInt32(dm[0]);

        int m = Convert.ToInt32(dm[1]);

        int result = Solve(s, d, m);
        Console.Write(result);
        Console.Read();
    }
}
