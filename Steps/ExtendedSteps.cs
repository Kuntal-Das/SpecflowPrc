using System;
using TechTalk.SpecFlow;

namespace specflowPrc1
{
    [Binding]
    public class ExtendedSteps
    {
        public readonly EmployeeDetails employeeDetails; //POCO Obj
        public readonly ScenarioContext _scenarioContext;
        public ExtendedSteps(ScenarioContext scenarioContext, EmployeeDetails empDetails)
        {
            this._scenarioContext = scenarioContext;
            this.employeeDetails = empDetails;
        }
        public ExtendedSteps(ScenarioContext scenarioContext) : this(scenarioContext, null) { }
        public ExtendedSteps(EmployeeDetails empDetails) : this(null, empDetails) { }

        [Then(@"I should get the value from Extended steps")]
        public void ThenIShouldGetTheValueFromExtendedSteps()
        {
            Console.WriteLine(employeeDetails.ToString());
        }
    }
}