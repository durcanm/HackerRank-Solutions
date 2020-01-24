// Complete the checkMagazine function below.
static void checkMagazine(string[] magazine, string[] note)
{
    var words = new Dictionary<string, int>();

    for (int i = 0; i < magazine.Length; i++)
    {
        int count = 0;

        if (words.TryGetValue(magazine[i], out count))
        {
            words[magazine[i]] += 1;
        }
        else
        {
            words.Add(magazine[i], 1);
        }
    }

    for (int i = 0; i < note.Length; i++)
    {
        int count = 0;

        if (words.TryGetValue(note[i], out count))
        {
            words[note[i]] -= 1;

            if (words[note[i]] < 0)
            {
                Console.WriteLine("No");
                return;
            }
        }
        else
        {
            Console.WriteLine("No");
            return;
        }
    }

    Console.WriteLine("Yes");
}