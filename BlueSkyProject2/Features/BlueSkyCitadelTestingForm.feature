Feature: BlueSkyCitadelTestingForm
	In order to be a guru tester
	I want to test the BlueSky CitadeL Testing Form
	Which has a lot of elements that i will be automating in future

@regression @blueskyform
Scenario: Valid Form Submission
	Given I navigate to BlueSky citadel website
	And I click on the Automation Testing Form
	When I enter the Single Line Text
	And I select two in the Select box
	And I enter Email
	And I enter Password
	And I select the Multi-Select
	And I select the Radio List
	And I select the Checkbox List
	And I select United Kingdom as Country
	And I select 14th of the current month
	And i click on the Single Check box
	And I Paragraph Text
	And I click on the Submit button
	Then the message "Your form has been successfully submitted."



	Scenario: Invalid Form Submission
	Given I navigate to BlueSky citadel website
	And I click on the Automation Testing Form
	When I enter the Single Line Text 
	And I select two in the Select box
	And I enter Email
	#And I enter Password
	And I select the Multi-Select
	And I select the Radio List
	And I select the Checkbox List
	And I select United Kingdom as Country
	And I select 14th of the current month
	And i click on the Single Check box
	And I Paragraph Text
	And I click on the Submit button
	Then the error message "Please correct errors before submitting this form."
	And the page url is "http://blueskycitadel.com/automation-testing-form/"
