// Complete the catAndMouse function below.
static string catAndMouse(int x, int y, int z)
{
    if (Math.Abs(x - z) < Math.Abs(y - z)) { return "Cat A"; }
    else if (Math.Abs(x - z) > Math.Abs(y - z)) { return "Cat B"; }
    else { return "Mouse C"; }
}