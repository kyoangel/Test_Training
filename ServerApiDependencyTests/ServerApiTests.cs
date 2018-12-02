using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServerApiDependency.Tests
{
	[TestClass()]
	public class ServerApiTests
	{
		/// <summary>
		/// LV 1, verify api correct response
		/// 100分
		/// </summary>
		[TestMethod()]
		public void post_cancelGame_third_party_success_test()
		{
			// Assert success
			Assert.Fail();
		}

		/// <summary>
		/// LV 2, verify specific exception be thrown
		/// 300分
		/// </summary>
		[TestMethod()]
		public void post_cancelGame_third_party_fail_test()
		{
			// Assert PostToThirdParty() return not correct should throw AuthFailException
			Assert.Fail();
		}

		/// <summary>
		/// LV 3, verify specific method be called
		/// 500分
		/// </summary>
		[TestMethod()]
		public void post_cancelGame_third_party_exception_test()
		{
			// Assert SaveFailRequestToDb() be called once
			Assert.Fail();
		}
	}
}