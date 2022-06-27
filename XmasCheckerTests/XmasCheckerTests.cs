using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XmasCheckerTests
{
	[TestClass()]
	public class XmasCheckerTests
	{
		[TestMethod()]
		public void Today_is_not_xmas()
		{
			var xmasChecker = new XmasChecker.XmasChecker();

			var actual = xmasChecker.IsTodayXmas();

			Assert.AreEqual(false, actual);
		}

		[TestMethod()]
		public void Today_is_xmas()
		{
			var xmasChecker = new XmasChecker.XmasChecker();

			var actual = xmasChecker.IsTodayXmas();

			Assert.AreEqual(true, actual);
		}
	}
}