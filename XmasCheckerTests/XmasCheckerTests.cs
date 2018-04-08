using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace XmasChecker.Tests
{
    [TestClass()]
    public class XmasCheckerTests
    {
        [TestMethod()]
        public void test_today_is_xmas()
        {
            var fakeXmasChecker = new fakeXmasChecker();
            fakeXmasChecker.SetToday(new DateTime(2018, 12, 25));
            Assert.IsTrue(fakeXmasChecker.IsTodayXmas());
        }
    }

    public class fakeXmasChecker : XmasChecker
    {
        private DateTime? _today;

        internal override DateTime GetToday()
        {
            return _today ?? DateTime.Today;
        }

        internal void SetToday(DateTime today)
        {
            _today = today;
        }
    }
}