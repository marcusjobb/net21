using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.StepDefinitions
{
    [Binding]
    public class NedraknareTillJulaftonStepDefinitions
    {
        DateTime current = default;
        int amountOfDays = 0;
        [Given(@"That today is (.*)-(.*)-(.*)")]
        public void GivenThatTodayIs(int year, int month, int day)
        {
            current = new DateTime(year, month, day);            
        }

        [When(@"the method is called")]
        public void WhenTheMethodIsCalled()
        {

            amountOfDays = XmasDayCounter.DaysTill.XmasEve(current);
        }

        [Then(@"it should return (.*)")]
        public void ThenItShouldReturn(int days)
        {
            amountOfDays.Should().Be(days);
        }
    }
}
