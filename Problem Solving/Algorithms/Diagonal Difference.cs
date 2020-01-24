/*
* Complete the 'diagonalDifference' function below.
*
* The function is expected to return an INTEGER.
* The function accepts 2D_INTEGER_ARRAY arr as parameter.
*/

public static int diagonalDifference(List<List<int>> arr)
{
    int sum1 = 0;
    int sum2 = 0;

    for (int i = 0; i < arr.Count; i++)
    {
        sum1 += arr[i][i];
        sum2 += arr[i][arr.Count - 1 - i];
    }

    return Math.Abs(sum1 - sum2);
}