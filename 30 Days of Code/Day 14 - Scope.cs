class Difference
{
    private int[] elements;
    public int maximumDifference;

    // Add your code here
    public Difference(int[] arr)
    {
        this.elements = arr;
    }

    public void computeDifference()
    {
        var min = this.elements.Min();
        var max = this.elements.Max();
        this.maximumDifference = max - min;
    }

} // End of Difference Class