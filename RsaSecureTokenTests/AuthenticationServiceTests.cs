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
            var target = new FakeAuthService();
            var fakeProfile = Substitute.For<IProfileDao>();
            fakeProfile.GetPassword(Arg.Any<string>()).Returns("Tdd");
            target.SetProfileDao(fakeProfile);

            var fakeToken = Substitute.For<IRsaTokenDao>();
            fakeToken.GetRandom(Arg.Any<string>()).Returns("520999");
            target.SetRsaToken(fakeToken);

            var actual = target.IsValid("Kyo", "Tdd520999");

            //always failed
            Assert.IsTrue(actual);
        }
    }

    public class FakeAuthService : AuthenticationService
    {
        private IProfileDao _profile;
        private IRsaTokenDao _token;

        protected override IProfileDao GetProfileDao()
        {
            return _profile ?? base.GetProfileDao();
        }

        public void SetProfileDao(IProfileDao profile)
        {
            _profile = profile;
        
        }

        protected override IRsaTokenDao GetRsaToken()
        {
            return _token ?? base.GetRsaToken();
        }

        public void SetRsaToken(IRsaTokenDao token)
        {
            _token = token;
        }
    }
}