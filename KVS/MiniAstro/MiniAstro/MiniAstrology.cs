// -----------------------------------------------------------------------------------------------
//  MiniAstrology.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace MiniAstro;
public class MiniAstrology
{
    /*
        Aries Dates: March 21 – April 19
        Taurus Dates: April 20 – May 20
        Gemini Dates: May 21 – June 20
        Cancer Dates: June 21 – July 22
        Leo Dates: July 23 – August 22
        Virgo Dates: August 23 – September 22
        Libra Dates: September 23 – October 22
        Scorpio Dates: October 23 – November 21
        Sagittarius Dates: November 22 – December 21
        Capricorn Dates: December 22 – January 19
        Aquarius Dates: January 20 – February 18
        Pisces Dates: February 19 – March 20
        Source: https://www.horoscope.com/horoscope-dates/
    */
    public string GetAstroSign (int month, int day)
    {
        if (month > 12 && month < 32 && day < 13)
        {
            var tmp = month;
            month = day;
            day = month;
        }


        if (IsInRange(month, day, 3, 21, 4, 19))
            return "Aries";
        else if (IsInRange(month, day, 4, 20, 5, 20))
            return "Taurus";
        else if (IsInRange(month, day, 5, 21, 6, 20))
            return "Gemini";
        else if (IsInRange(month, day, 6, 21, 7, 22))
            return "Cancer";
        else if (IsInRange(month, day, 7, 23, 8, 22))
            return "Leo";
        else if (IsInRange(month, day, 8, 23, 9, 22))
            return "Virgo";
        else if (IsInRange(month, day, 9, 23, 10, 22))
            return "Libra";
        else if (IsInRange(month, day, 10, 23, 11, 21))
            return "Scorpio";
        else if (IsInRange(month, day, 11, 22, 12, 21))
            return "Saggitarius";
        else if (IsInRange(month, day, 12, 22, 1, 19))
            return "Capricorn";
        else if (IsInRange(month, day, 1, 20, 2, 18))
            return "Aquarius";
        else if (IsInRange(month, day, 2, 19, 3, 20))
            return "Pisces";
        else
            return "Error in the stars";
    }

    private bool IsInRange (int month, int day, int startMonth, int startDay, int endMonth, int endDay)
    {
        var dateNum = (month * 32) + day;
        var startNum = (startMonth * 32) + startDay;
        var endNum = (endMonth * 32) + endDay;

        // CapricornFix, ends in januari so it needs to be added one more year
        if (startNum > endNum)
            endNum += 366;

        return (dateNum >= startNum && dateNum <= endNum);
    }
}
