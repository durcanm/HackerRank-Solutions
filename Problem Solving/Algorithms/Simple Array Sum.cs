/*
* Complete the simpleArraySum function below.
*/
static int simpleArraySum(int[] ar)
{
    int sum = 0;

    for (int i = 0; i < ar.Length; i++)
    {
        sum += ar[i];
    }

    return sum;
}