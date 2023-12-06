using System;

public class Calendar
{
    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public static void PrintWeekdays()
    {
        foreach (var day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            if ((int)day >= 0 && (int)day <= 4)
                Console.WriteLine(day);
        }
    }
}

