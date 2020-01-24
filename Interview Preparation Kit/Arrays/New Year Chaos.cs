// Complete the minimumBribes function below.
static void minimumBribes(int[] q)
{
    bool tooChaotic = false;
    int bribes = 0;

    var bribesCnt = new Dictionary<int, int>();
    foreach (var item in q)
    {
        bribesCnt.Add(item, 0);
    }

    for (int i = 0; i < q.Length - 1; i++)
    {
        var bribeFound = false;
        for (int ii = 0; ii < q.Length - 1; ii++)
        {
            if (q[ii] > q[ii + 1])
            {
                bribes++;

                bribesCnt[q[ii]] += 1;

                if (bribesCnt[q[ii]] > 2)
                { tooChaotic = true; Console.WriteLine("Too chaotic"); break; }

                bribeFound = true;

                //swap
                var tmp = q[ii];
                q[ii] = q[ii + 1];
                q[ii + 1] = tmp;
            }
        }

        if (tooChaotic || !bribeFound) { break; }
    }

    if (!tooChaotic)
    {
        Console.WriteLine(bribes);
    }
}