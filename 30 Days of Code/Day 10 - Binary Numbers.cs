class Solution
{
    static int binaryNumbers(int n)
    {
        string binary = Convert.ToString(n, 2);
        int consecutive = 0;
        int max = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i].ToString() == "1")
            {
                consecutive++;
                if (consecutive > max) { max = consecutive; }
            }
            else { consecutive = 0; }
        }

        return max;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(binaryNumbers(n));
    }
}