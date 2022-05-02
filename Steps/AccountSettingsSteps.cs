using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Ubeeqo.Hooks;
using Ubeeqo.PageObjects;

namespace Ubeeqo.Steps
{
    [Binding]
    public class AccountSettingsSteps
    {
        public IWebDriver driver = BaseTest.driver;
        AccountSettingsPage _accountsettingsPage = new AccountSettingsPage();





        [When(@"I clcik on account settings")]
        public void WhenIClcikOnAccountSettings()
        {
            _accountsettingsPage.ClickAccount();
        }

        [When(@"I enter first name ""(.*)""")]
        public void WhenIEnterFistName(string name)
        {
            _accountsettingsPage.EnterFirstname(name);
        }

        [When(@"I enter last name ""(.*)""")]
        public void WhenIEnterLastName(string name)
        {
            _accountsettingsPage.Enterlastname(name);
        }

        [When(@"I click on save changes button")]
        public void WhenIClickOnSaveChangesButton()
        {
            _accountsettingsPage.ClickSave();
        }


        [Then(@"A success image is displayed")]
        public void ThenASucessImageIsDisplayed()
        {
            Assert.IsTrue(_accountsettingsPage.SuccessMessageIsDisplayed());
        }
    }
}
