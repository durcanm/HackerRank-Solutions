// Complete the hourglassSum function below.
static int hourglassSum(int[][] arr)
{
    int largest = Int32.MinValue;

    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr[i].Length; j++)
        {
            if (i + 2 >= arr.Length || j + 2 >= arr[i].Length) { continue; }

            int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                + arr[i + 1][j + 1]
                        + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

            if (sum > largest) { largest = sum; }
        }
    }

    return largest;
}