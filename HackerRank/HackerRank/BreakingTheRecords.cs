using System;

class BreakingBad
{

    // Complete the breakingRecords function below.
    static int[] BreakingRecords(int[] score)
    {
        int reigningChampion = score[0];
        int reigningDoofus = score[0];

        int medals = 0;
        int dungPiles = 0;

        for (int i = 1; i < score.Length; i++)
        {
            if (score[i] > reigningChampion)
            {
                medals++;
                reigningChampion = score[i];
            }
            else if (score[i] < reigningDoofus)
            {
                dungPiles++;
                reigningDoofus = score[i];
            }
        }
        return new int[] { medals, dungPiles };
    }

    public static void Run()
    {
        //int[] score = new int[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };
        int[] score = new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
        int[] result = BreakingRecords(score);

        Console.Write(result[0] + " " + result[1]);
        Console.Read();
    }
}
