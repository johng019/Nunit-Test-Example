using Calculator;
using NUnit.Framework;

namespace NunitTestCalculator
{
    [TestFixture]
    public class NUnitCalcTest
    {
        //Try naming the method for the purpose it is intended

        [Test]
        public void VerifyAddMethodReturnsCorrectSumOfTwoNumbers()
        {
            //Arrange..set up the test
            CalculatorClass obj = new CalculatorClass();
            //Act...actionable event
            int result = obj.Add(4, 5);
            //Assert..expected result
            Assert.That(result, Is.EqualTo(9));
        }

        //continue to set up additional tests in the same manner
        [Test]
        public void VerifySubtractMethodReturnsCorrectDifferenceOfTwoNumbers()
        {
            CalculatorClass obj2 = new CalculatorClass();
            int result = obj2.Subtract(4, 5);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void VerifyMultiplyMethodReturnsCorrectProductOfTwoNumbers()
        {
            CalculatorClass obj3 = new CalculatorClass();
            int result = obj3.Multiply(4, 5);
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void VerifyDivideMethodReturnsCorrectDividendOfTwoNumbers()
        {
            CalculatorClass obj4 = new CalculatorClass();
            int result = obj4.Divide(8, 4);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
