using FluentAssertions;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Ubeeqo.Hooks;
using Ubeeqo.PageObjects;

namespace Ubeeqo.Steps
{
    [Binding]
    public class LogoutSteps
    {
        public IWebDriver driver = BaseTest.driver;
        LogoutPage _logoutPage = new LogoutPage();



        [When(@"I click on personal profile on the header")]
        public void WhenIClickOnPersonalProfileOnTheHeader()
        {
            _logoutPage.ClickPersonal();
        }

        [When(@"I click on sign out on the dropdown")]
        public void WhenIClickOnSignOutOnTheDropdown()
        {
            _logoutPage.ClickSignout();

        }


        //[Then(@"login is displayed")]
        //public void ThenLoginIsDisplayed()
        //{
        //    Assert.IsTrue(_logoutPage.LoginIsDisplayed());
        //}

        [Then(@"logout page is displayed")]
        public void LogoutIsDisplayed()
        {
            _logoutPage.IsLogoutPageDisplayed().Should().BeTrue();
        }
    }
}
