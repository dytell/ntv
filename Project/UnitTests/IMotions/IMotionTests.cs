using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab2Varian8;
using NUnit.Framework;
using NUnitLite;
namespace UnitTests.IMotions
{
    [TestFixture]
    class IMotionTests
    {
        [Test]
        [TestCase(4, TestName = "Тестирование X0 при присваивании 4.")]
        public void X0Test(double count)
        {
            var acceleratedMotion = new AcceleratedMotion
            {
                X0 = count
                
            };

        }
        [Test]
        [TestCase(4, TestName = "Тестирование AX при присваивании 4.")]
        public void XATest(double count)
        {
            var acceleratedMotion = new AcceleratedMotion
            {
                AX = count
                

            };

        }
        [Test]
        [TestCase(4, TestName = "Тестирование Time при присваивании 4.")]
        public void TimeTest(uint count)
        {
            var acceleratedMotion = new AcceleratedMotion
            {
                Time = count


            };

        }
        [Test]
        [TestCase(4, TestName = "Тестирование VX при присваивании 4.")]
        public void VXTest(double count)
        {
            var acceleratedMotion = new AcceleratedMotion
            {
                AX = count


            };

        }

    }
}
