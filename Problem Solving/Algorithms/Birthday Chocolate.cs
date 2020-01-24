// Complete the birthday function below.
static int birthday(List<int> s, int d, int m)
{
    int waysCount = 0;

    for (int i = 0; i < s.Count; i++)
    {
        int sum = s[i];
        int length = 1;

        if (length == m && sum == d) { waysCount++; continue; }

        for (int j = i + 1; j < s.Count; j++)
        {
            sum += s[j];
            length++;

            if (sum > d && length < m) { break; }
            if (sum == d && length == m) { waysCount++; break; }
        }
    }

    return waysCount;
}