// Complete the reverseArray function below.
static int[] reverseArray(int[] a)
{
    int[] b = new int[a.Length];

    for (int i = a.Length - 1; i >= 0; i--)
    {
        b[a.Length - 1 - i] = a[i];
    }

    return b;
}