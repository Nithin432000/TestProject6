using System;
using TechTalk.SpecFlow;

namespace TestProject6
{
    [Binding]
    public class LoginStepDefinitions
    {
        public LoginStepDefinitions(FeatureContext fc)
        {
            Console.WriteLine(fc.FeatureInfo.Description);
        }
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            
        }

        [When(@"I enter Username (.*)")]
        public void WhenIEnterUsername(string username)
        {
            Console.WriteLine("Username: " + username);
        }

        [When(@"I enter Password (.*)")]
        public void WhenIEnterPassword(string password)
        {
            Console.WriteLine("Password: " + password);
        }

        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
           
        }

        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            
        }
    }
}
