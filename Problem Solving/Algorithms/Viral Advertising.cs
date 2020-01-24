// Complete the viralAdvertising function below.
static int viralAdvertising(int n)
{
    int day = n;
    int shared = 5;
    int liked = 0;
    int cumulative = 0;

    for (int i = 1; i <= day; i++)
    {
        liked = (int)Math.Floor((double)shared / 2);
        shared = liked * 3;
        cumulative += liked;
    }

    return cumulative;
}