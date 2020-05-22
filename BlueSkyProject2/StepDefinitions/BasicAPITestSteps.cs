using FluentAssertions;
using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace BlueSkyProject2.StepDefinitions
{
    [Binding]
    public class BasicAPITestSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I have access to Github")]
        public void GivenIHaveAccessToGithub()
        {
            client = new RestClient("https://api.github.com/users/desola0478/repos");
            client.Timeout = -1;
            
        }

        [When(@"I search for a user")]
        public void WhenISearchForAUser()
        {
            request = new RestRequest(Method.GET);
            response = client.Execute(request);
            
        }

        [Then(@"the result is displayed")]
        public void ThenTheResultIsDisplayed()
        {
            Assert.That(response.Content.Length > 0);
            Assert.That(response.StatusCode.ToString() == "OK");
            Assert.That(response.IsSuccessful.ToString() == "True");
        }


        [Then(@"the details contains ""(.*)""")]
        public void ThenTheDetailsContains(string user)
        {
            response.Content.Should().Contain(user);
        }

    }
}
