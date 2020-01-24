/*
* Complete the pageCount function below.
*/
static int pageCount(int n, int p)
{
    int flipCount = 0;
    bool isPageInFirstHalf = p <= n / 2;

    if (isPageInFirstHalf) { flipCount = p / 2; }
    else { if (n % 2 == 0) { flipCount = (1 + n - p) / 2; } else { flipCount = (n - p) / 2; } }

    return flipCount;
}