using BlueSkyProject2.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyProject2.StepDefinitions
{
    [Binding]
    public class DataDrivenWithinfeatureStepSteps
    {
        BlueSkyCitadelWebsitePage blueSkyCitadelWebsitePage;

        public DataDrivenWithinfeatureStepSteps()
        {
            blueSkyCitadelWebsitePage = new BlueSkyCitadelWebsitePage();
        }

       [Given(@"I navigate to site ""(.*)""")]
        public void GivenINavigateToSite(string url)
        {
            blueSkyCitadelWebsitePage.NavigateToSite(url);
        }
        
        [When(@"I enter my email ""(.*)""")]
        public void WhenIEnterMyEmail(string email)
        {
            blueSkyCitadelWebsitePage.EnterEmail(email);
        }

        [When(@"I enter Password ""(.*)")]
        public void WhenIEnterPassword(string password)
        {
            blueSkyCitadelWebsitePage.EnterPassword(password);
        }



        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            
        }
        
        [Then(@"the form is submitted")]
        public void ThenTheFormIsSubmitted()
        {
            
        }
    }
}
