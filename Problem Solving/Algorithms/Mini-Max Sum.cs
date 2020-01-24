// Complete the miniMaxSum function below.
static void miniMaxSum(int[] arr)
{
    long sum = 0;
    long min = long.MaxValue;
    long max = long.MinValue;

    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];

        if (arr[i] < min) { min = arr[i]; }
        if (arr[i] > max) { max = arr[i]; }
    }

    Console.WriteLine($"{sum - max} {sum - min}");
}