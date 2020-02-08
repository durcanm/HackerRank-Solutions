// Write Your Code Here
int swapCount = 0;

for (int i = 0; i < a.Length - 1; i++)
{
    if (a[i] > a[i + 1])
    {
        swapCount++;

        int tmp = a[i];
        a[i] = a[i + 1];
        a[i + 1] = tmp;

        i = -1;
    }
}

Console.WriteLine($"Array is sorted in {swapCount} swaps.");
Console.WriteLine($"First Element: {a[0]}");
Console.WriteLine($"Last Element: {a[a.Length - 1]}");