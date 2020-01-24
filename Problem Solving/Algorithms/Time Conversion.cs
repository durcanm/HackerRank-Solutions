/*
* Complete the timeConversion function below.
*/
static string timeConversion(string s)
{
    string AmPm = s.Substring(s.Length - 2, 2);
    bool isPM = AmPm == "PM";
    string hour = s.Split(':')[0];
    string minute = s.Split(':')[1];
    string second = s.Split(':')[2].Replace(AmPm, "");

    if (isPM)
    {
        if (hour != "12")
        {
            hour = (Convert.ToInt32(hour) + 12).ToString();
        }

        if (hour == "24") { hour = "00"; }
    }
    else
    {
        if (hour == "12") { hour = "00"; }
    }

    return $"{hour}:{minute}:{second}";
}