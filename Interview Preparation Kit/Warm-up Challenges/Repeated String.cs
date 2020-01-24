// Complete the repeatedString function below.
static long repeatedString(string s, long n)
{
    long occurance = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i].ToString() == "a") { occurance++; }
    }

    long multiply = n / s.Length;
    long remainder = (1 + multiply) * s.Length % n;

    occurance *= multiply;

    for (int i = 0; i < s.Length - remainder; i++)
    {
        if (s[i].ToString() == "a") { occurance++; }
    }

    return occurance;
}