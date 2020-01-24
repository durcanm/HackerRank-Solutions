// Complete the sockMerchant function below.
static int sockMerchant(int n, int[] ar)
{
    var d = new Dictionary<int, int>();

    for (int i = 0; i <= ar.Length - 1; i++)
    {
        int x;
        d.TryGetValue(ar[i], out x);

        if (x == default(int)) { d[ar[i]] = 1; }
        else { d[ar[i]] = x + 1; }
    }

    int pairCount = 0;

    foreach (var item in d)
    {
        pairCount += (int)Math.Floor((decimal)item.Value / 2);
    }

    return pairCount;
}