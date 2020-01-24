// Complete the countingValleys function below.
static int countingValleys(int n, string s)
{
    int valleys = 0;
    int currentSeaLevel = 0;
    int previousSeaLevel = 0;

    for (int i = 0; i < n; i++)
    {
        previousSeaLevel = currentSeaLevel;

        switch (s[i].ToString())
        {
            case "U":
                currentSeaLevel++;
                break;
            case "D":
                currentSeaLevel--;
                break;
        }

        if (currentSeaLevel == 0 && previousSeaLevel == -1)
        {
            valleys++;
        }
    }

    return valleys;
}