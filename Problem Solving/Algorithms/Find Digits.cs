// Complete the findDigits function below.
static int findDigits(int n)
{
    int divisors = 0;

    for (int i = 0; i < n.ToString().Length; i++)
    {
        int divisor = Convert.ToInt32((n.ToString()[i]).ToString());
        if (divisor != 0 && n % divisor == 0) { divisors++; }
    }

    return divisors;
}