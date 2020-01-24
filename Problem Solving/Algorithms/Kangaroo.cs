// Complete the kangaroo function below.
static string kangaroo(int x1, int v1, int x2, int v2)
{
    if ((x1 > x2 && v1 > v2) || (x2 > x1 && v2 > v1)) { return "NO"; }

    int difCur = Math.Abs(x1 - x2);
    int difPrev = int.MaxValue;

    while (difCur < difPrev)
    {
        difPrev = difCur;

        x1 += v1;
        x2 += v2;

        if (x1 == x2) { return "YES"; }

        difCur = Math.Abs(x1 - x2);
    }

    return "NO";
}