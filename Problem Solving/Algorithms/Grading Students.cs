/*
* Complete the 'gradingStudents' function below.
*
* The function is expected to return an INTEGER_ARRAY.
* The function accepts INTEGER_ARRAY grades as parameter.
*/

public static List<int> gradingStudents(List<int> grades)
{
    for (int i = 0; i < grades.Count; i++)
    {
        if (grades[i] < 38) { continue; }

        int roundedGrade = ((grades[i] / 5) + 1) * 5;

        if (roundedGrade - grades[i] < 3) { grades[i] = roundedGrade; }
    }

    return grades;
}