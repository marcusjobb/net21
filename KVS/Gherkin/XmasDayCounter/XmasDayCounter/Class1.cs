namespace XmasDayCounter
{
    public static class DaysTill
    {
        /// <summary>
        /// Returns the amount of days from current date (or given date) till this years christmas
        /// </summary>
        /// <param name="current">A date</param>
        /// <returns>and <see cref="int"/> that represents amount of days</returns>
        public static int XmasEve(DateTime current = default)
        {
            if (current == default)
            {
                current = DateTime.Now;
            }

            var xmas = new DateTime(current.Year, 12, 24);
            return  (xmas - current).Days;
        }
    }
}