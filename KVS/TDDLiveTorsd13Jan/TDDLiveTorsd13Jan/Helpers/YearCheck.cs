namespace TDDLiveTorsd13Jan.Helpers
{
    public static class YearCheck
    {
        public static bool IsLeapyear (int year) => year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
    }
}