static void Main(String[] args)
{
    string S = Console.ReadLine();

    try
    {
        int x = int.Parse(S);
        Console.WriteLine(x);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Bad String");
    }
    finally
    {
        ;
    }
}