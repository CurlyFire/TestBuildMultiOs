using NUnit.Framework;

namespace Domain.Tests
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void DoIt()
        {
            var p = new Person();
            Assert.AreEqual("hello", p.SayHello());
        }
    }
}
