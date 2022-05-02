using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Ubeeqo.Hooks;
using Ubeeqo.PageObjects;

namespace Ubeeqo.Steps
{
    [Binding]
    public class BookingSteps
    {
        public IWebDriver driver = BaseTest.driver;
        BookingPage _bookingPage = new BookingPage();


        [When(@"I enter a location ""(.*)""")]
        public void WhenIEnterALocation(string location)
        {
           
            _bookingPage.EnterLocation(location);
        }


        [When(@"I click on book a vehicle")]
        public void WhenIClickOnBookAVehicle()
        {
            _bookingPage.ClickBook();
        }

        [Then(@"a validation modal pop up displayed blocking the bookings")]
        public void ThenAValidationModalPopUpDisplayedBlockingTheBookings()
        {
            driver.SwitchTo().ActiveElement();
            Assert.IsTrue(_bookingPage.ValidationModalPopUpDisplayed());
        }


    }
}
