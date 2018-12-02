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
	    /// <summary>
	    /// 300分
	    /// </summary>
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