public class DivisileSumPair
{

    // Complete the divisibleSumPairs function below.
    static int divisibleSumPairs(int n, int k, int[] ar)
    {
        int[] modK = new int[k];
        for (int i = 0; i < k; i++)
        {
            modK[i] = 0;
            for (int j = 0; j < n; j++)
            {
                if (ar[j] % k == i)
                {
                    modK[i]++;
                }
            }
        }
        int sumWay = 0;
        for (int i = 0; i <= k / 2; i++)
        {
            if (i == 0)
            {
                sumWay += modK[i] * (modK[i] - 1) / 2;
            }
            else if (i == k / 2)
            {
                sumWay += (k % 2 == 0) ? (modK[i] * (modK[i] - 1) / 2) : (modK[i] * modK[k - i]);
            }
            else
            {
                sumWay += modK[i] * modK[k - i];
            }
        }
        return sumWay;
    }

    public static void Run()
    {
        int n = 6;

        int k = 7;

        int[] ar = new int[] { 1, 3, 2, 6, 1, 2 };
        int result = divisibleSumPairs(n, k, ar);
    }
}
