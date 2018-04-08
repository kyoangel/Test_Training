using System;

namespace XmasChecker
{
    public class XmasChecker
    {
        public bool IsTodayXmas()
        {
            // implement
            var today = DateTime.Today;
            if (today.Month == 12 && today.Day == 25)
            {
                return true;
            }
            return false;
        }
    }
}