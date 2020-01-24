/*
* Complete the 'pickingNumbers' function below.
*
* The function is expected to return an INTEGER.
* The function accepts INTEGER_ARRAY a as parameter.
*/

public static int pickingNumbers(List<int> a)
{
    int max = 2;
    var dict = new Dictionary<int, int>();

    for (int i = 0; i < a.Count; i++)
    {
        if (!dict.TryGetValue(a[i], out int foo))
        {
            dict.Add(a[i], 1);
        }
        else
        {
            dict[a[i]] += 1;
        }
    }

    var d = dict.OrderBy(x => x.Key).ToList();

    max = dict.OrderByDescending(x => x.Value).First().Value;

    for (int i = 0; i < d.Count - 1; i++)
    {
        if (d[i].Key - d[i + 1].Key != -1) { continue; }

        if (d[i].Value + d[i + 1].Value > max) { max = d[i].Value + d[i + 1].Value; }
    }

    return max;
}