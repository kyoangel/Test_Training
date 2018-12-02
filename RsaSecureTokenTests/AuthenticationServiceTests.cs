using Microsoft.VisualStudio.TestTools.UnitTesting;
using RsaSecureToken;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsaSecureToken.Tests
{
    [TestClass()]
    public class AuthenticationServiceTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            var target = new AuthenticationService();

			// implement your own act
            var actual = target.IsValid("","");

            // make your own Assert
            Assert.Fail();
        }
    }
}