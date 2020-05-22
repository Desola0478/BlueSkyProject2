Feature: DataDrivenWithinFeatureStep
    In order not to repeat my data or to be able to update my data from feature file
    I want to add my data to the feature file

@mytag
Scenario: Validate Form
    Given I navigate to site "https://www.giftrete.com"
    When I enter my email "desolakin@gmail.com"
    And I click on submit button 
    Then the form is submitted

