class Solution
{
    static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        string message = "";

        if (N % 2 != 0)
        {
            message = "Weird";
        }
        else if (N >= 2 && N <= 5)
        {
            message = "Not Weird";
        }
        else if (N >= 6 && N <= 20)
        {
            message = "Weird";
        }
        else if (N > 20)
        {
            message = "Not Weird";
        }

        Console.WriteLine(message);
    }
}