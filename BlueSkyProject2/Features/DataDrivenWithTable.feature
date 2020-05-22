Feature: DataDrivenWithTable
	In order not to repeat my data or to be able to update my data from feature file
    I want to add my data to the feature file


@mytag
Scenario Outline: Validate Form With Table
    Given I navigate to site "http://blueskycitadel.com/automation-testing-form"
    When I enter my email and password
    | Email               | Password |
    | desolakin@gmail.com | Babes    |
    