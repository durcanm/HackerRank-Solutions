// Complete the minimumSwaps function below.
static int minimumSwaps(int[] arr)
{
    int swaps = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == i + 1) { continue; }

        int pos = -1;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] == i + 1) { pos = j; break; }
            if (arr[j + 1] == i + 1) { pos = j + 1; break; }

            j++;
        }

        //swap
        int tmp = arr[i];
        arr[i] = arr[pos];
        arr[pos] = tmp;
        swaps++;
    }

    return swaps;
}