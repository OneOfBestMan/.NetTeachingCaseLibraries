using System;
using NUnit.Framework;

namespace SQLTrace.UnitTests
{
    [TestFixture]
    public class UpdatesCheckerTests
    {
        [Test]
        public void TestGetLatestVersion()
        {
            Version v = UpdatesChecker.GetLatestVersion();
            Assert.IsNotNull(v);
            Assert.Greater(v,  new Version("0.0.0.0"));
        }
    }
}
