class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write($"{arr[i]} ");
        }
    }
}