using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Ubeeqo.Hooks;

namespace Ubeeqo.PageObjects
{
    class LoginPage
    {
        public IWebDriver driver;
        public LoginPage()
        {
            driver = BaseTest.driver;
        }

        private By Username = By.XPath("//input[@placeholder='yours@example.com']");
        private By Password = By.XPath("//input[@placeholder='your password']");
        private By Loginbutton = By.XPath("//span[@class='auth0-label-submit']");
        private By Agree = By.CssSelector("button[id='didomi-notice-agree-button'] span");
        private By Logo = By.XPath("//img[@alt='Logo']");


        public void EnterUsername(string name)
        {
            driver.FindElement(Username).SendKeys(name);
        }

        public void EnterPassword(string pwd)
        {
            driver.FindElement(Password).SendKeys(pwd);
        }

        public void ClickLoginbutton()
        {
            driver.FindElement(Loginbutton).Click();
        }

        public void ClickAgree()
        {
            driver.FindElement(Agree).Click();
        }

        public bool ThenUbeeqoLogoIsDisplayed()
        {
            return driver.FindElement(Logo).Displayed;
        }








    }
}
