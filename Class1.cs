using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace ClassLibrary3
{
    [SetUpFixture]
    public class Initialization
    {
        public IWebDriver driver;
        [SetUp]
        public void BeforeTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Navigate().GoToUrl("https://www.skype.com/uk/");
        }

        [TearDown]
        public void AfterTest()
        {
            driver.Close();
        }
    }
}
