using Nozomi.net.Services;
using NUnit.Framework;

namespace Nozomi.net.Tests
{
    public class ComponentTests
    {
        [SetUp]
        public void Setup()
        {
            var nozomiApi = new NozomiApiClient("");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}