using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Calculator;

namespace TestCalculator
{
    [TestFixture]
    public class TestFunctionality
    {
        double a;
        double b;
        string sign;

        [Test]
        public void SumCheck()
        {

            ReaderAndOutput r = new ReaderAndOutput(2,48);
            Assert.AreEqual(50, MathOperations.Sum(r));
        }


        [Test]
        public void MinusCheck()
        {
            ReaderAndOutput r = new ReaderAndOutput(23, 3);
            Assert.AreEqual(20, MathOperations.Minus(r));
        }


        [Test]
        public void MultiCheck()
        {
            ReaderAndOutput r = new ReaderAndOutput(5, 5);
            Assert.AreEqual(25, MathOperations.Multi(r));
        }

        [Test]
        public void DivCheckNegative()
        {

            ReaderAndOutput r = new ReaderAndOutput(20,5);
            Assert.AreNotEqual(5, MathOperations.Multi(r));
        }

        [Test]
        public void ConvertStringToEnumCheck()
        {
            Assert.AreEqual(Sign.Plus, MathOperations.ConvertStringToEnum("+"));
        } 
    }
}

