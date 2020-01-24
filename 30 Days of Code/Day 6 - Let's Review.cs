class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        int N = int.Parse(Console.ReadLine());

        for (int n = 1; n <= N; n++)
        {
            string s = Console.ReadLine();

            string[] arr = s.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j += 2)
                {
                    Console.Write(arr[i][j].ToString());
                }

                Console.Write(" ");

                for (int j = 1; j < arr[i].Length; j += 2)
                {
                    Console.Write(arr[i][j].ToString());
                }

                Console.WriteLine("");
            }
        }
    }
}