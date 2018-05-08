using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace RsaSecureToken.Tests
{
    [TestClass()]
    public class AuthenticationServiceTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            var fakeProfile = Substitute.For<ProfileDao>();
            fakeProfile.GetRegisterTimeInMinutes(Arg.Any<string>());
            var fakeToken = Substitute.For<RsaTokenDao>();
            fakeToken.GetRandom(Arg.Any<int>()).ReturnsForAnyArgs("123456");
            var target = new AuthenticationService(fakeProfile, fakeToken);

            var actual = target.IsValid("Kyo", "123456");

            //always failed
            Assert.IsTrue(actual);
        }
    }
}