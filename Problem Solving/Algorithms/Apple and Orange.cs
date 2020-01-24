// Complete the countApplesAndOranges function below.
static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
{
    int apple = 0;
    int orange = 0;

    for (int i = 0; i < apples.Length; i++)
    {
        apples[i] += a;

        if (apples[i] >= s && apples[i] <= t) { apple++; }
    }

    for (int i = 0; i < oranges.Length; i++)
    {
        oranges[i] += b;

        if (oranges[i] >= s && oranges[i] <= t) { orange++; }
    }

    Console.WriteLine(apple);
    Console.WriteLine(orange);
}