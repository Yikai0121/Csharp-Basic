using System;


namespace FirstCsharp
{
    public class LeapYear
    {
        
        public static bool LeapYearIs(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;

        }


    }
}
