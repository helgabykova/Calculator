using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Calculator;

namespace TestCalculator
{
    [TestFixture]
    public class TestFunctionality
    {

        [Test]
        public void SumCheck()
        {
            var p = Program.Sum(2, 8);
            Assert.AreEqual(2+8, Program.Sum(2,8));
        }


        [Test]
        public void MinusCheck()
        {

            Assert.AreEqual(10, Program.Minus(15,5));
        }


        [Test]
        public void MultiCheck()
        {

            Assert.AreEqual(10, Program.Multi(2, 5));
        }

        [Test]
        public void DivCheck()
        {

            Assert.AreNotEqual(20, Program.Div(100, 5));
        }
    }
}
