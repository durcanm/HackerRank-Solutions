// Complete the divisibleSumPairs function below.
static int divisibleSumPairs(int n, int k, int[] ar)
{
    int pairsCount = 0;

    for (int i = 0; i < ar.Length; i++)
    {
        for (int j = i + 1; j < ar.Length; j++)
        {
            if ((ar[i] + ar[j]) % k == 0) { pairsCount++; }
        }
    }

    return pairsCount;
}