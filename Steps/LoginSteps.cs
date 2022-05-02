using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Ubeeqo.Hooks;
using Ubeeqo.PageObjects;

namespace Ubeeqo.Steps
{
    [Binding]
    public class LoginSteps
    {
        public IWebDriver driver = BaseTest.driver;
        LoginPage _loginPage = new LoginPage();




        [Given(@"I navigate to Ubeeqo website")]
        public void GivenINavigateToUbeeqoWebsite()
        {
            driver.Navigate().GoToUrl(@"https://webapp.ubeeqo.com/");
        }

        [When(@"I enter the username ""(.*)""")]
        public void WhenIEnterTheUsername(string name)
        {
            _loginPage.EnterUsername(name);
        }

        [When(@"I enter the password ""(.*)""")]
        public void WhenIEnterThePassword(string pwd)
        {
            _loginPage.EnterPassword(pwd);
        }

        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            _loginPage.ClickLoginbutton();
        }

        [When(@"I click on agree button on the cookies banner")]
        public void WhenIClickOnAgreeButtonOnTheCookiesBanner()
        {
            _loginPage.ClickAgree();
        }



        //Asserting that the logo is displayed on the landing page using nUnit 
        [Then(@"ubeeqo logo banner is displayed")]
        public void ThenUbeeqoLogoBannerIsDisplayed()
        {
            Assert.IsTrue(_loginPage.ThenUbeeqoLogoIsDisplayed());
        }
    }
}
