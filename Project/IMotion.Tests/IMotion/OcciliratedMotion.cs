using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2Varian8;

namespace IMotion.Tests.IMotion
{
    [TestFixture]
    public class OcciliratedMotionTest
    {
        [Test]
        [TestCase(3, TestName = "Тестирование Count при значении 3")]
        public void F0Test(double count)
        {
            var oscillatoryMotion = new OscillatoryMotion
            {
                F0 = count
            };
        }

        [Test]
        [TestCase(4, TestName = "Тестирование Count при значении 4")]
        public void xMTest(double count)
        {
            var oscillatoryMotion = new OscillatoryMotion();
            oscillatoryMotion.XM = count;
        }
        [Test]
        [TestCase(-5, TestName = "Тестирование Count при значении -5")]
        public void xMTestExeption(double count)
        {
            var oscillatoryMotion = new OscillatoryMotion();
            Assert.Throws<MinusExeption>(() => oscillatoryMotion.XM = count);
        }

        [Test]
        [TestCase(6, 8, 7, 2, 5, TestName = "Тест калькулятора")]
        public void CalculateCoordination(double counX0, double countW0, double countF0, double XM, int countTime)
        {
            var calulator = new OscillatoryMotion(counX0, XM, countTime, countF0, countW0);
            var result = calulator.CalculateCoordination();
            Assert.AreEqual(7.11F, result, 1e-3);
        }

        [Test]      
        public void sd()
        {
            OscillatoryMotion oscillatoryMotion = new OscillatoryMotion();
        }



    }
}
