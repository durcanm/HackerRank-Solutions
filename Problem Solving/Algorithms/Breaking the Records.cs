// Complete the breakingRecords function below.
static int[] breakingRecords(int[] scores)
{
    int highest = scores[0];
    int lowest = scores[0];

    int bestCount = 0;
    int worstCount = 0;

    for (int i = 0; i < scores.Length; i++)
    {
        if (scores[i] > highest) { bestCount++; highest = scores[i]; }
        else if (scores[i] < lowest) { worstCount++; lowest = scores[i]; }
    }

    return new int[] { bestCount, worstCount };
}