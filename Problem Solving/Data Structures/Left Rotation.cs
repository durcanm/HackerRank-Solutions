static int[] rotLeft(int[] a, int d)
{
    int[] b = new int[a.Length];
    int shift = d % a.Length;

    for (int i = 0; i < a.Length; i++)
    {
        var pos = i - shift;

        if (pos < 0) { pos = a.Length - Math.Abs(pos); }

        b[pos] = a[i];

    }

    return b;
}