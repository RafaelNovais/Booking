using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TestBooking.qaGeneral;

namespace TestBooking.Main
{
    [TestFixture]
    class qaMain : qaSetup
    {

        [Test]
        public void T1_DriverExecute()
        {
            String Local = "Limerick, Limerick County, Irlanda";

            driver.Navigate().GoToUrl("https://www.booking.com/");

            IWebElement webElement = null;
            webElement = driver.FindElement(By.Id("ss"));
            webElement.SendKeys(Local);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement webElementSelect = null;
            webElementSelect = driver.FindElement(By.CssSelector(".sb-autocomplete__item-with_photo:nth-child(1)"));
            webElementSelect.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement webElementSearch = null;
            webElementSearch = driver.FindElement(By.CssSelector(".sb-searchbox__button > span:nth-child(1)"));
            webElementSearch.Click();
        }


    }
}
