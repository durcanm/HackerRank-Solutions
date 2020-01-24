// Complete the migratoryBirds function below.
static int migratoryBirds(List<int> arr)
{
    var typeCounts = new int[5];

    for (int i = 0; i < arr.Count; i++)
    {
        typeCounts[arr[i] - 1] += 1;
    }

    int max = 0;
    int type = 0;

    for (int i = 0; i < typeCounts.Length; i++)
    {
        if (typeCounts[i] > max && type < i + 1) { max = typeCounts[i]; type = i + 1; }
    }

    return type;
}