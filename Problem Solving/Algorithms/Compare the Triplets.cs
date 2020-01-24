// Complete the compareTriplets function below.
static List<int> compareTriplets(List<int> a, List<int> b)
{
    int bob = 0;
    int alice = 0;

    for (int i = 0; i < a.Count(); i++)
    {
        if (a[i] > b[i]) { alice++; }
        else if (a[i] < b[i]) { bob++; }

    }

    return new List<int> { alice, bob };
}