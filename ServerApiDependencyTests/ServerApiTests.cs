using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using ServerApiDependency.Enum;
using ServerApiDependency.Enums;
using ServerApiDependency.Utility.CustomException;
using System;

namespace ServerApiDependency.Tests
{
    [TestClass()]
    public class ServerApiTests
    {
        private ServerApi _serverApi;

        [TestInitialize]
        public void TestInit()
        {
            var fakeLogger = Substitute.For<ILogger>();
            _serverApi = Substitute.For<ServerApi>(fakeLogger);
        }

        /// <summary>
        /// LV 1, verify api correct response
        /// </summary>
        [TestMethod()]
        public void post_cancelGame_third_party_success_test()
        {
            // Assert success
            GivenPostToThirdPartyReturn(0);

            Assert.AreEqual(ServerResponse.Correct, _serverApi.CancelGame());
        }

        private void GivenPostToThirdPartyReturn(int returnValue)
        {
            _serverApi.PostToThirdParty(Arg.Any<ApiType>(), Arg.Any<string>()).ReturnsForAnyArgs(returnValue);
        }

        /// <summary>
        /// LV 2, verify specific exception be thrown
        /// </summary>
        [TestMethod()]
        public void post_cancelGame_third_party_fail_test()
        {
            // Assert PostToThirdParty() return not correct should throw AuthFailException
            GivenPostToThirdPartyReturn(99);

            Action actual = () => { _serverApi.CancelGame(); };
            actual.Should().Throw<AuthFailException>();
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