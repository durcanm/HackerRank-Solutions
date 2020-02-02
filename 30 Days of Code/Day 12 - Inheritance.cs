class Student : Person
{
    private int[] testScores;

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string firstName, string lastName, int id, int[] scores)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.testScores = scores;
    }

    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public string Calculate()
    {
        var avg = this.testScores.Average();

        if (avg < 40) { return "T"; }
        else if (avg < 55 && avg >= 40) { return "D"; }
        else if (avg < 70 && avg >= 55) { return "P"; }
        else if (avg < 80 && avg >= 70) { return "A"; }
        else if (avg < 90 && avg >= 80) { return "E"; }
        else if (avg <= 100 && avg >= 90) { return "O"; }
        else { return ""; }
    }
}