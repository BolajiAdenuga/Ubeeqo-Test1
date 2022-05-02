using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Ubeeqo.Hooks;

namespace Ubeeqo.PageObjects
{
    class AccountSettingsPage
    {
        public IWebDriver driver;
        public AccountSettingsPage()
        {
            driver = BaseTest.driver;
        }


        private By Account = By.XPath("//a[normalize-space()='Account settings']");
        private By Firstname = By.XPath("//input[@placeholder='First name']");
        private By Lastname = By.XPath("//input[@placeholder='Last name']");
        private By Save = By.XPath("//span[normalize-space()='Save changes']");
        private By Success = By.CssSelector(".v1-font-large.v1-font-weight-bold");


        public void ClickAccount()
        {
            driver.FindElement(Account).Click();
        }



        public void EnterFirstname(string name)
        {

            driver.FindElement(Firstname).SendKeys(Keys.Control + "a");
            driver.FindElement(Firstname).SendKeys(name);

        }

        public void Enterlastname(string name)
        {
            driver.FindElement(Lastname).SendKeys(Keys.Control + "a");
            driver.FindElement(Lastname).SendKeys(name);
        }

        public void ClickSave()
        {
            driver.FindElement(Save).Click();
        }

        public bool SuccessMessageIsDisplayed()
        {
            return driver.FindElement(Success).Displayed;
        }
    }
}
