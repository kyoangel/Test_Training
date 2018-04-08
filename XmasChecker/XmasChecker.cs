using System;

namespace XmasChecker
{
    public class XmasChecker
    {
        public bool IsTodayXmas()
        {
            // implement
            var today = GetToday();
            if (today.Month == 12 && today.Day == 25)
            {
                return true;
            }
            return false;
        }

        internal virtual DateTime GetToday()
        {
            return DateTime.Today;
        }
    }
}