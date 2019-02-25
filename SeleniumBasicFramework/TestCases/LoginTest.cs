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
            driver.Url = "http://www.store.demoqa.com";

            var homePage = new HomePage(driver);
            homePage.MyAccount.Click();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication();

            driver.Close();
        }
    }
}