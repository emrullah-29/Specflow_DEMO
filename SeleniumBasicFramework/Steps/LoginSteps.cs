using NUnit.Framework;
using OnlineStore.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SeleniumBasicFramework.Steps
{
    [Binding]
    public class LoginScenariosSteps
    {
        IWebDriver driver;
        [Given(@"Im in the login page")]
        public void GivenImInTheLoginPage()
        {
            driver = new ChromeDriver();
            driver.Url = "http://demo.guru99.com/V4/";
        }
        
        [When(@"I have entered valid username and password")]
        public void WhenIHaveEnteredValidUsernameAndPassword()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication();
        }


        [Then(@"I would be able to login successfully")]
        public void ThenIWouldBeAbleToLoginSuccessfully()
        {
            var homePage = new HomePage(driver);
            Assert.IsTrue(homePage.IsHeadingDisplayed());
            driver.Close();
        }
    }
}
