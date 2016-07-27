using System;
using TechTalk.SpecFlow;
using Calculator;
using NUnit.Framework;

namespace Calculator
{
    [Binding]
    public class CalculatorSteps
    {
        ReaderAndOutput r;
        double result;
        double a;
        double b;

        //First number entering
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(string number)
        {
            a = Convert.ToDouble(number);
        }

        //Second number entering
        [Given(@"I entered (.*) into the calculator")]
        public void WhenIEnteredIntoTheCalculator(string number)
        {
            b = Convert.ToDouble(number);
        }

        //Plus function
        [When(@"I have entered \+")]
        public void WhenIHaveEntered()
        {
            r = new ReaderAndOutput(a, b);
            result = MathOperations.Sum(r);
        }
    
        [Then(@"the Sum result should be (.*) on the screen")]
        public void ThenTheSumResultShouldBeOnTheScreen(string getresult)
        {
            Assert.AreEqual(result, Convert.ToDouble(getresult));
        }

        //Multi function
        [When(@"I have entered \*")]
        public void GivenIHaveEnteredMultiSign()
        {
            r = new ReaderAndOutput(a, b);
            result = MathOperations.Multi(r);
        }

        [Then(@"the Multi result should be (.*) on the screen")]
        public void ThenTheMultiResultShouldBeOnTheScreen(string getresult)
        {
            Assert.AreEqual(result, Convert.ToDouble(getresult));
        }

        //Div function
        [When(@"I have entered \/")]
        public void GivenIHaveEnteredDivSign()
        {
            r = new ReaderAndOutput(a, b);
            result = MathOperations.Div(r);
        }

        [Then(@"the Div result should be (.*) on the screen")]
        public void ThenTheDivResultShouldBeOnTheScreen(string getresult)
        {
            Assert.AreEqual(result, Convert.ToDouble(getresult));
        }

        //Minus function
        [When(@"I have entered \-")]
        public void GivenIHaveEnteredMinusSign()
        {
            r = new ReaderAndOutput(a, b);
            result = MathOperations.Minus(r);
        }
        [Then(@"the Minus result should be (.*) on the screen")]
        public void ThenTheMinusResultShouldBeOnTheScreen(string getresult)
        {
            Assert.AreEqual(result, Convert.ToDouble(getresult));
        }


    }
}
