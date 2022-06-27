using Microsoft.VisualStudio.TestTools.UnitTesting;
using RsaSecureToken;

namespace RsaSecureTokenTests
{
    [TestClass()]
    public class AuthenticationServiceTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            var sut = new AuthenticationService();

			// implement your own act
            var actual = sut.IsValid("","");

            Assert.IsTrue(actual);
        }
    }
}