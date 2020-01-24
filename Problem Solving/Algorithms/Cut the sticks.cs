// Complete the cutTheSticks function below.
static int[] cutTheSticks(int[] arr)
{
    var result = new List<int>();
    bool allZero = true;

    while (allZero)
    {
        allZero = false;
        int shortest = int.MaxValue;
        int sticksCut = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0 & arr[i] < shortest) { shortest = arr[i]; allZero = true; }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                arr[i] -= shortest;
                sticksCut++;
            }
        }

        if (sticksCut > 0) { result.Add(sticksCut); }
    }

    return result.ToArray();
}