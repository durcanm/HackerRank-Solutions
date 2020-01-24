// Complete the jumpingOnClouds function below.
static int jumpingOnClouds(int[] c)
{
    int jumps = 0;

    int pos = 0;
    while (pos < c.Length - 1)
    {
        if ((pos + 2 < c.Length) && (c[pos + 1] == 0 && c[pos + 2] == 1))
        {
            pos += 1;
        }
        else
        {
            pos += 2;
        }

        jumps++;
    }

    return jumps;
}