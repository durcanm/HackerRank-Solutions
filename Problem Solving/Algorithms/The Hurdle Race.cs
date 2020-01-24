// Complete the hurdleRace function below.
static int hurdleRace(int k, int[] height)
{
    int max = 0;

    for (int i = 0; i < height.Length; i++)
    {
        if (height[i] > max) { max = height[i]; }
    }

    if (max - k < 0)
    {
        return 0;
    }
    else
    {
        return max - k;
    }
}