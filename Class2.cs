using NUnit.Framework;
using OpenQA.Selenium;

namespace ClassLibrary3
{   [TestFixture]
    class Program : Initialization
    {
        [Test]
        public void Test1()
        {
            driver.FindElement(By.XPath("//a[@id='uhfLogo']")).Click();
        }
    }
}
