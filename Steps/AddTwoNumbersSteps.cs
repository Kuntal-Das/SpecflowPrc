using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace specflowPrc1
{
    [Binding]
    public class AddTwoNumbersSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public AddTwoNumbersSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

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

        [When(@"I fill mandatory details in the form")]
        public void WhenIFillMandatoryDetailsInTheForm(Table tbl)
        {
            // EmployeeDetails empDetails = tbl.CreateInstance<EmployeeDetails>();
            var empDetails = tbl.CreateSet<EmployeeDetails>();

            foreach (var emp in empDetails)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        [When(@"I fill mandatory details in the form (.*), (.*), (.*) and (.*)")]
        public void WhenIFillMandatoryDetailsInTheForm(string name, int age, int phone, string email)
        {
            // Console.WriteLine($"\n{name}\t{age}\t{phone}\t{email}");

            // _scenarioContext["InfoForNextStep"] = "Step1 Passed";

            // Console.WriteLine(_scenarioContext["InfoForNextStep"].ToString());

            List<EmployeeDetails> empList = new List<EmployeeDetails>();

            empList.Add(new EmployeeDetails()
            {
                Name = name,
                Age = age,
                Phone = phone,
                Email = email
            });

            // Save the value in ScenarioContext
            _scenarioContext.Add("EmpDetailsList", empList);

            IEnumerable<EmployeeDetails> gotfromScenarioContext = _scenarioContext.Get<IEnumerable<EmployeeDetails>>("EmpDetailsList");

            // foreach (EmployeeDetails emp in gotfromScenarioContext)
            // {
            //     Console.WriteLine(emp.ToString());
            // }

            Console.WriteLine($"\n Title: {_scenarioContext.ScenarioInfo.Title}");
            Console.WriteLine($"\n CurrentScenarioBlock: {_scenarioContext.CurrentScenarioBlock}");
        }
    }
}