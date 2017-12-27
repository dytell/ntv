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
    public class AcceleratedMotionTest
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
        [TestCase(-5, TestName = "Тестирование AX при присваивании 4.")]
        public void AXTest(double count)
        {
            var acceleratedMotion = new AcceleratedMotion();
            Assert.Throws<MinusExeption>(() => acceleratedMotion.AX = count);

        }

        [Test]
        [TestCase(-5, TestName = "Тестирование VX при присваивании 4.")]
        public void Vx(double count)
        {
            var acceleratedMotion = new AcceleratedMotion();
            Assert.Throws<MinusExeption>(() => acceleratedMotion.V0X = count);

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
        [TestCase(-5, TestName = "Тестирование Time при присваивании -5.")]
        
        public void TimeTest(int count)
        {
            var acceleratedMotion = new AcceleratedMotion();         
            Assert.Throws<MinusExeption>(() => acceleratedMotion.Time = count);
        }

        //_x = _x0 + _v0X * _time + ((_aX * (_time * _time)) / 2);
        [Test]
        [TestCase(10,7,6,5,TestName ="Тест калькулятора")]
        public void CalculateCoordination(double counAx,double countVx,double countX0,int countTime)
        {
            var calulator = new AcceleratedMotion(countX0,counAx,countTime,countVx);
            var result = calulator.CalculateCoordination();
            Assert.AreEqual(166, result);
        }
        

    }
}

