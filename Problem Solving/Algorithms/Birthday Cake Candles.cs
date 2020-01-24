// Complete the birthdayCakeCandles function below.
static int birthdayCakeCandles(int[] ar)
{
    int max = 0;
    int count = 0;

    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] == max) { count++; }
        if (ar[i] > max) { max = ar[i]; count = 1; }
    }

    return count;
}