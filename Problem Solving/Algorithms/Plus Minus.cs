// Complete the plusMinus function below.
static void plusMinus(int[] arr)
{
    int positive = 0;
    int negative = 0;
    int zero = 0;

    for (int i = 0; i <= arr.Length - 1; i++)
    {
        if (arr[i] > 0) { positive++; }
        else if (arr[i] < 0) { negative++; }
        else if (arr[i] == 0) { zero++; }
    }

    Console.WriteLine(String.Format("{0:0.00000}", (decimal)positive / (decimal)arr.Length));
    Console.WriteLine(String.Format("{0:0.00000}", (decimal)negative / (decimal)arr.Length));
    Console.WriteLine(String.Format("{0:0.00000}", (decimal)zero / (decimal)arr.Length));
}