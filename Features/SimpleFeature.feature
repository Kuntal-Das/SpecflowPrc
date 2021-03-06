Feature: AddTwoNumbers
    In Order to avoid silly mistakes
    As a math idiot
    I want to be told the sum of two numbers

    @SmokeTest
    Scenario: Add two numbers
        Given I have entered 50 into the calculator
        And I have entered 70 into the calculator
        When I press add
        Then The result should be 120 on the screen

    Scenario: Create a new employee with mandatory details
        # Given I have opened my application
        # Then I should see employee details page
        When I fill mandatory details in the form
            | Name       | Age | Phone     | Email               |
            | Kuntal Das | 23  | 123456890 | kuntaldas@email.com |
            | John       | 30  | 981321591 | john@email.com      |
            | Sam        | 42  | 416546513 | sam@email.com       |
    # And I click the save button
    # Then I should see all the details saved in my application and DB

    Scenario Outline: Create a new employee with mandatory details with scenario outline
        # Given I have opened my application
        # Then I should see employee details page
        When I fill mandatory details in the form <Name>, <Age>, <Phone> and <Email>
        # And I click the save button
        # Then I should see all the details saved in my application and DB

        Examples:
            | Name       | Age | Phone     | Email               |
            | Kuntal Das | 23  | 123456890 | kuntaldas@email.com |
            | John       | 30  | 981321591 | john@email.com      |
            | Sam        | 42  | 416546513 | sam@email.com       |

    Scenario: Ckeck if I could get the details entered via Table from Extended Steps
        When I fill all the mandatory details in form
            | Name       | Age | Phone      | Email                |
            | Kuntal Das | 23  | 3241413123 | kuntal.das@email.com |
        Then I should get the value from Extended steps