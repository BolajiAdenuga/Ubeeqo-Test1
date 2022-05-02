using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Ubeeqo.Hooks;

namespace Ubeeqo.PageObjects
{
    class LogoutPage
    {
        public IWebDriver driver;
        public LogoutPage()
        {
            driver = BaseTest.driver;
        }


        private By Personal = By.XPath("//*[@id='app']/div/section/div[1]/nav/div[3]/label/img[2]");
        private By Signout = By.XPath("//div[@class='MainMenu__link MainMenu__item MainMenu__contact__title phModal_close']");
        //private By Login = By.XPath("//*[@id='auth0-lock-container-1']/div/div[2]/form/div/div/button/span");


        public void ClickPersonal()
        {
            driver.FindElement(Personal).Click();
        }

        public void ClickSignout()
        {
            driver.FindElement(Signout).Click();
        }

        //public bool IsLogoutPageDisplayed()
        //{
        //    return driver.FindElement(Login).Displayed;
        //}

        public bool IsLogoutPageDisplayed()
        {
            return driver.Url.Contains("https://auth.ubeeqo.com/login?state");
        }
    }
}
