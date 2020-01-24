class Solution
{
    static void Main(String[] args)
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";


        // Declare second integer, double, and String variables.

        // Read and save an integer, double, and String to your variables.

        int j = Convert.ToInt32(Console.ReadLine());
        double t = Convert.ToDouble(Console.ReadLine());
        string x = Console.ReadLine();

        // Print the sum of both integer variables on a new line.

        Console.WriteLine(i + j);

        // Print the sum of the double variables on a new line.

        Console.WriteLine(string.Format("{0:0.0}", d + t));

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.

        Console.WriteLine($"{s}{x}");
    }
}