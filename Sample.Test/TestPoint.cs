using System;
using Triangle;
using NUnit.Framework;

namespace Sample.Test
{
    [TestFixture]
    public class TestPoint
    {
        private Diem A;

        [SetUp]
        public void Setup()
        {
            A = new Diem(2, 5);
        }

        [Test]
        public void Canh()
        {
            Diem B = new Diem(5, 9);
            Assert.AreEqual(5, A.Canh(B));
        }
    }
}
