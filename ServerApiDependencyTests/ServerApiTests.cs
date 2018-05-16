using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using ServerApiDependency.Enum;
using ServerApiDependency.Enums;

namespace ServerApiDependency.Tests
{
    [TestClass()]
    public class ServerApiTests
    {
        /// <summary>
        /// LV 1, verify api correct response
        /// </summary>
        [TestMethod()]
        public void post_cancelGame_third_party_success_test()
        {
            // Assert success
            var api = Substitute.For<ServerApi>();
            api.PostToThirdParty(Arg.Any<ApiType>(), Arg.Any<string>()).ReturnsForAnyArgs(0);
            var actual = api.CancelGame();
            Assert.AreEqual(ServerResponse.Correct, actual);
        }

        /// <summary>
        /// LV 2, verify specific exception be thrown
        /// </summary>
        [TestMethod()]
        public void post_cancelGame_third_party_fail_test()
        {
            // Assert PostToThirdParty() return not correct should throw AuthFailException
            Assert.Fail();
        }

        /// <summary>
        /// LV 3, verify specific method be called
        /// </summary>
        [TestMethod()]
        public void post_cancelGame_third_party_exception_test()
        {
            // Assert SaveFailRequestToDb() be called once
            Assert.Fail();
        }
    }
}