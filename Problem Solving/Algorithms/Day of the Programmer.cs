// Complete the dayOfProgrammer function below.
static string dayOfProgrammer(int year)
{
    string DayoftheProgrammer = "";
    bool con1 = year > 1918;
    bool con2 = year % 4 == 0;
    bool con3 = year % 100 == 0;
    bool con4 = year % 400 == 0;
    bool isLeapYear = (!con1 && con2) || (con1 && con2 && !con3) || (con1 && con2 && con3 && con4);
    var days = new int[] { 31, (year == 1918 ? 14 : 28) + (isLeapYear ? 0 : 1), 31, 30, 31, 30, 31, 31, 30 };

    if (year == 1918)
    {
        DayoftheProgrammer = $"{25 + (isLeapYear ? 0 : 1)}.09.{year}";
    }
    else
    {
        DayoftheProgrammer = $"{12 + (isLeapYear ? 0 : 1)}.09.{year}";
    }

    return DayoftheProgrammer;
}