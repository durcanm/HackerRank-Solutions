// Complete the designerPdfViewer function below.
static int designerPdfViewer(int[] h, string word)
{
    var alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

    var heights = new Dictionary<string, int>();

    for (int i = 0; i < alphabet.Length; i++)
    {
        heights.Add(alphabet[i], h[i]);
    }

    int maxHeight = 0;

    for (int i = 0; i < word.Length; i++)
    {
        if (heights[word[i].ToString()] > maxHeight)
        {
            maxHeight = heights[word[i].ToString()];
        }
    }

    var area = word.Length * maxHeight;

    return area;
}