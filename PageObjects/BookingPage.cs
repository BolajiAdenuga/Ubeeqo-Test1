using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Ubeeqo.Hooks;

namespace Ubeeqo.PageObjects
{
    class BookingPage
    {
        public IWebDriver driver;
        public BookingPage()
        {
            driver = BaseTest.driver;
        }

        private By Location = By.CssSelector("Input[data-test-id*='input_search']");
        private By Book = By.CssSelector("#app > div > section > div.phLayoutMapview.ph-layout-page.d-flex");
        private By Popup = By.CssSelector(".v1-focus-color-primary-lightest.align-bottom.text-center.pill.px-3.v1-color-white.v1-background-color-primary");
        



        public void EnterLocation(string location)
        {
            driver.FindElement(Location).SendKeys(location);
            driver.FindElement(Location).SendKeys(Keys.Enter);
        }

        
        
        public void ClickBook()
        {
            driver.FindElement(Book).Click();
        }

        public bool ValidationModalPopUpDisplayed()
        {
            driver.SwitchTo().ActiveElement();
            return driver.FindElement(Popup).Displayed;
           
        }




    }
}
