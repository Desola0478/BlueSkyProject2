using BlueSkyProject2.PageObjects;
using FluentAssertions;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyProject2.StepDefinitions
{
    [Binding]
    public class BlueSkyCitadelTestingFormSteps
    {
        BlueSkyCitadelWebsitePage blueSkyCitadelWebsitePage;

        public  BlueSkyCitadelTestingFormSteps()
        {
            blueSkyCitadelWebsitePage = new BlueSkyCitadelWebsitePage();
        }

        [Given(@"I navigate to BlueSky citadel website")]
        public void GivenINavigateToBlueSkyCitadelWebsite()
        {

            blueSkyCitadelWebsitePage.NavigateToBlueSkycitadelwebsite();
        }
        
        [Given(@"I click on the Automation Testing Form")]
        public void GivenIClickOnTheAutomationTestingForm()
        {
            blueSkyCitadelWebsitePage.AutomationTestingForm();
        }

        [When(@"I enter the Single Line Text")]
        public void WhenIEnterTheSingleLineText()
        {
            blueSkyCitadelWebsitePage.AutomationTestingForm();
        }


        [When(@"I select two in the Select box")]
        public void WhenISelectTwoInTheSelectBox()
        {
            blueSkyCitadelWebsitePage.SelectTwoFromSelectOneTwoThree();
        }
        
        [When(@"I enter Email")]
        public void WhenIEnterEmail()
        {
            blueSkyCitadelWebsitePage.EnterEmail();
        }

        [When(@"I enter Password")]
        public void WhenIEnterPassword()
        {
        //    blueSkyCitadelWebsitePage.EnterPassword();
        }
        

        [When(@"I select the Multi-Select")]
        public void WhenISelectTheMulti_Select()
        {
            blueSkyCitadelWebsitePage.SelectMultiSelector();
        }
        
        [When(@"I select the Radio List")]
        public void WhenISelectTheRadioList()
        {
            blueSkyCitadelWebsitePage.SelectTwoFromSelectRadio();
        }
        
        [When(@"I select the Checkbox List")]
        public void WhenISelectTheCheckboxList()
        {
            blueSkyCitadelWebsitePage.SelectThreeFromCheckBox();
        }
        
        [When(@"I select United Kingdom as Country")]
        public void WhenISelectUnitedKingdomAsCountry()
        {
            blueSkyCitadelWebsitePage.SelectUnitedKingdomFromCountry();
        }
        
        [When(@"I select (.*)th of the current month")]
        public void WhenISelectThOfTheCurrentMonth(int p0)
        {
            blueSkyCitadelWebsitePage.SelectDateFromCalender();
        }

        [When(@"i click on the Single Check box")]
        public void WhenIClickOnTheSingleCheckBox()
        {
            blueSkyCitadelWebsitePage.SingleCheckBox();
        }

        [When(@"I Paragraph Text")]
        public void WhenIParagraphText()
        {
            blueSkyCitadelWebsitePage.EnterParagraphText();
        }


        [When(@"I click on the Submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
            blueSkyCitadelWebsitePage.Submit();
        }
        
        [Then(@"the message ""(.*)""")]
        public void ThenTheMessage(string message)
        {
            
        }

        [Then(@"the error message ""(.*)""")]
        public void ThenTheErrorMessage(string errormessage)
        {
            blueSkyCitadelWebsitePage.CheckErrorMessageIsDisplayed();

            Assert.AreEqual(errormessage, blueSkyCitadelWebsitePage.GetTextForError());
            
        }


        [Then(@"the page url is ""(.*)""")]
        public void ThenThePageUrlIs(string url)
        {
            Assert.AreEqual(url, blueSkyCitadelWebsitePage.GetPageUrl);
           


            url.Should().Be(blueSkyCitadelWebsitePage.GetPageUrl);

            url.Should().Contain("citadel");
            blueSkyCitadelWebsitePage.GetPageUrl.Should().Contain("citadel");

        }
          
    }
}
