// Complete the twoStrings function below.
static string twoStrings(string s1, string s2)
{
    string strLong;
    string strShort;

    if (s1.Length >= s2.Length)
    { strLong = s1; strShort = s2; }
    else
    { strLong = s2; strShort = s1; }

    var dict = new Dictionary<string, int>();

    int foo = 0;

    for (int i = 0; i < strLong.Length; i++)
    {
        if (!dict.TryGetValue(strLong[i].ToString(), out foo)) { dict.Add(strLong[i].ToString(), 0); }
    }

    for (int i = 0; i < strShort.Length; i++)
    {
        if (dict.TryGetValue(strShort[i].ToString(), out foo)) { return "YES"; }
    }

    return "NO";
}