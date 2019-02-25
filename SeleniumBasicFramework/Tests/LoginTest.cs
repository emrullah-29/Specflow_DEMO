using NUnit.Framework;
using OnlineStore.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OnlineStore.TestCases
{
    class LogInTest
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://demo.guru99.com/V4/";

           
            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication();
            var homePage = new HomePage(driver);
            Assert.IsTrue(homePage.IsHeadingDisplayed());
            driver.Close();
        }
    }
}