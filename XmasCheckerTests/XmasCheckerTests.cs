using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace XmasChecker.Tests
{
    [TestClass()]
    public class XmasCheckerTests
    {
        private fakeXmasChecker _fakeXmasChecker = new fakeXmasChecker();

        [TestMethod()]
        public void test_today_is_xmas()
        {
            GivenToday(new DateTime(2018, 12, 25));
            TheResultShouldBe(true);
        }

        private void TheResultShouldBe(bool expected)
        {
            Assert.AreEqual(expected, _fakeXmasChecker.IsTodayXmas());
        }

        private void GivenToday(DateTime today)
        {
            _fakeXmasChecker.SetToday(today);
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