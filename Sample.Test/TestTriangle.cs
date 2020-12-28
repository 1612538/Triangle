using System;
using Triangle;
using NUnit.Framework;

namespace Sample.Test
{
    [TestFixture]
    public class TestTriangle
    {
        private TamGiac ABC;

        [Test]
        public void Has90()
        {
            ABC = new TamGiac(new Diem(-1, 0), new Diem(-2, 3), new Diem(5, 2));
            Assert.AreEqual(3, ABC.Loai());
        }

        [Test]
        public void Has90AndBalanced()
        {
            ABC = new TamGiac(new Diem(1, 2), new Diem(0, 0), new Diem(-2, 1));
            Assert.AreEqual(2, ABC.Loai());
        }

        [Test]
        public void Balanced()
        {
            ABC = new TamGiac(new Diem(-1, 1), new Diem(1, 3), new Diem(2, 0));
            Assert.AreEqual(4, ABC.Loai());
        }

        [Test]
        public void PerfectlyBalanced()
        {
            ABC = new TamGiac(new Diem(0,0), new Diem(-2, Math.Sqrt(12)), new Diem(2, Math.Sqrt(12)));
            Assert.AreEqual(1, ABC.Loai());
        }

        [Test]
        public void NormalTriangle()
        {
            ABC = new TamGiac(new Diem(0, 0), new Diem(-2, 1), new Diem(4, 1));
            Assert.AreEqual(0, ABC.Loai());
        }


        [Test]
        public void ChuVi()
        {
            ABC = new TamGiac(new Diem(-1, 1), new Diem(1, 3), new Diem(2, 0));
            Assert.AreEqual(Math.Sqrt(8) + Math.Sqrt(10)*2, ABC.ChuVi());
        }
    }

    
}
