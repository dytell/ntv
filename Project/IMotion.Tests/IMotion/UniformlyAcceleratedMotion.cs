using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2Varian8;
using NUnit.Framework;

namespace IMotion.Tests.IMotion
{
    [TestFixture]
    class UniformlyAcceleratedMotionTest
    {
        [Test]
        [TestCase(10, 7, 6, TestName = "Тест калькулятора равноускореный")]
        public void CalculateCoordination(double x0, double vX, int time)
        {
            var calulator = new UniformlyAcceleratedMotion(x0, vX, time);
            var result = calulator.CalculateCoordination();
            Assert.AreEqual(52, result);
        }
        [Test]
        [TestCase(-9, TestName = "Проверка времени на -9")]
        public void TimeTest(int count)
        {
            var acceleratedMotion = new UniformlyAcceleratedMotion();
            Assert.Throws<MinusExeption>(() => acceleratedMotion.Time = count);

        }
        [Test]
        [TestCase(5, TestName = "VX = 5")]
        public void VXTest(int count)
        {
            var acceleratedMotion = new UniformlyAcceleratedMotion
            {
                VX = 5
        };
            

        }

    }
}
