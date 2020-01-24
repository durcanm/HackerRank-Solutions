// Complete the angryProfessor function below.
static string angryProfessor(int k, int[] a)
{
    int count = 0;

    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] < 1) { count++; }
    }

    if (count >= k) { return "NO"; } else { return "YES"; }
}