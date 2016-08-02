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
        string Expresult;

        [Given(@"I have written <(.*)> and <(.*)>")]
        public void GivenIHaveWritten(string anumber, string bnumber)
        {
            try
            {
                a = Convert.ToDouble(anumber);
                b = Convert.ToDouble(bnumber);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Funtions
        [When(@"I have entered '(.*)'")]
        public void WhenIHaveEntered(string sign)
        {
            
                r = new ReaderAndOutput(a, b);
                if (sign == "+")
                {
                    result = MathOperations.Sum(r);
                }
                else if (sign == "-")
                {
                    result = MathOperations.Minus(r);
                }
                else if (sign == "*")
                {
                    result = MathOperations.Multi(r);
                }
                else if (sign == "/")
                {
                    result = MathOperations.Div(r);
                }
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string sign)
        {
            if (sign == "+")
            {
                Assert.AreEqual(Expresult, MathOperations.Sum(r));
            }
            else if (sign == "-")
            {
                Assert.AreEqual(Expresult, MathOperations.Minus(r));
            }
            else if (sign == "*")
            {
                Assert.AreEqual(Expresult, MathOperations.Multi(r));
            }
            else if (sign == "/")
            {
                Assert.AreEqual(Expresult, MathOperations.Div(r));
            }
            else
            {
                FormatException ex;
            }
            }
        }
    }
