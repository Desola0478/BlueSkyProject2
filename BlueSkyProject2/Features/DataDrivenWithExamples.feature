Feature: DataDrivenWithExamples
	In order not to repeat my data or to be able to update my data from feature file
    I want to add my data to the feature file



@mytag
Scenario Outline: Validate Form Example
    Given I navigate to site "https://www.giftrete.com"
    And I navigate to site "https://www.blueskycitadel.com/automation-testing-form"
    When I enter my email "<email>"
    And I enter Password "<password>
    And I click on submit button 
    Then the form is submitted


Examples: 
| Email               | Password |
| desolakin@gmail.com | Babes    |
| Ibabes5@yahoo.com   | Babes2   |