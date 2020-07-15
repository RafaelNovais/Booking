using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestBooking.qaGeneral
{
    public abstract class qaSetup
    {

        public static IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver("D:/Arquivos/Desenvolvimento/Teste Rafael/TestKneat/Driver");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
        }
    }
}
