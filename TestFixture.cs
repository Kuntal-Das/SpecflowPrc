using System;
using TechTalk.SpecFlow;

namespace specflowPrc1
{
    [Binding]
    class TestFixture
    {
        [BeforeFeature]
        public static void BeforeFeaturefunc()
        {
            Console.WriteLine("\n\n\tCalling BEFORE FEATURE\n\n");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("\n\n\tCalling BEFORE Scenario\n\n");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("\n\n\tCalling AFTER Scenario\n\n");
        }
    }
}