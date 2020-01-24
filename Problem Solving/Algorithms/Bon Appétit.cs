// Complete the bonAppetit function below.
static void bonAppetit(List<int> bill, int k, int b)
{
    int sharedCost = 0;
    for (int i = 0; i < bill.Count; i++)
    {
        if (i == k) { continue; }
        sharedCost += bill[i];
    }

    int overcharge = b - (sharedCost / 2);
    string result = overcharge == 0 ? "Bon Appetit" : overcharge.ToString();

    Console.WriteLine(result);
}