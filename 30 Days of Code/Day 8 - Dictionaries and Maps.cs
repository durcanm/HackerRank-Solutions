class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

        var d = new Dictionary<string, string>();

        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= count; i++)
        {
            var input = Console.ReadLine();
            var key = input.Split(' ')[0];
            var value = input.Split(' ')[1];

            d.Add(key, value);
        }

        for (int i = 1; i <= count; i++)
        {
            var query = Console.ReadLine();

            if (d.TryGetValue(query, out string val))
            {
                Console.WriteLine($"{query}={val}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}