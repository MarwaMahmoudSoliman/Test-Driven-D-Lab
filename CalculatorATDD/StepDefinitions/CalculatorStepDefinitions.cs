using System;
using TechTalk.SpecFlow;

namespace CalculatorATDD.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private readonly Calculator.Calculator _calculator = new Calculator.Calculator();
        private int _sumResult;

        [Given(@"User enters (.*) into calculator")]
        public void GivenUserEntersIntoCalculator(int p0)
        {
            _calculator.Enter(p0);
        }

        [When(@"User press add")]
        public void WhenUserPressAdd()
        {
            _sumResult = _calculator.Add();
        }

        [Then(@"Sum should be (.*)")]
        public void ThenSumShouldBe(int p0)
        {
            Assert.AreEqual(p0, _sumResult);
        }
    }
}
