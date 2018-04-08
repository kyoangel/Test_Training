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
            var fakeProfile = Substitute.For<IProfile>();
            fakeProfile.GetPassword("").ReturnsForAnyArgs("Tdd");
            var fakeToken = Substitute.For<IToken>();
            fakeToken.GetRandom("").ReturnsForAnyArgs("520999");
            var target = new AuthenticationService(fakeProfile, fakeToken);

            var actual = target.IsValid("Kyo", "Tdd520999");

            //always failed
            Assert.IsTrue(actual);
        }
    }
}