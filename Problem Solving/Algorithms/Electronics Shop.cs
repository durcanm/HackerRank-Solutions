/*
* Complete the getMoneySpent function below.
*/
static int getMoneySpent(int[] keyboards, int[] drives, int b)
{
    int nearestCost = -1;

    for (int k = 0; k < keyboards.Length; k++)
    {
        for (int d = 0; d < drives.Length; d++)
        {
            int sum = keyboards[k] + drives[d];

            if (sum == b) { nearestCost = sum; return sum; }
            if (sum > b) { continue; }
            if (sum < b && sum > nearestCost)
            {
                nearestCost = sum;
            }
        }
    }

    return nearestCost;
}