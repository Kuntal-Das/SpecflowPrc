using System;
using TechTalk.SpecFlow;

namespace specflowPrc1
{
    [Binding]
    public class AddTwoNumbersSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            Console.WriteLine(p0);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed ADD Button");
        }

        [Then(@"The result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            //grab the obj which has the value of 120 in the UI of the Application
            //replace with 120
            if (result == 120)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
                throw new Exception("The value is different");
            }
        }
    }
}