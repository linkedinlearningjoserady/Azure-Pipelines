using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AmazingApp.Models;

namespace AmazingAppTests
{
    [TestClass]
    public class IdentityUtilsTests
    {
        [TestMethod]
        public void WillNotShowRoleIfNull()
        {
            var name = "Matthew Manela";
            string role = null;
//omjin
            var display = IdentityUtils.FormatIdentityName(name, role);

            Assert.AreEqual("Matthew Manela", display);
        }

        [TestMethod]
        public void WillReturnCorrectIdentityFormat()
        {
            var name = "Matthew Manela";
            var role = "Engineering Manager";

            var display = IdentityUtils.FormatIdentityName(name, role);

            Assert.AreEqual("Matthew Manela (Engineering Manager)", display);
        }
    }
}
