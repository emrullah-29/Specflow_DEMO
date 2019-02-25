using NUnit.Framework;
using OnlineStore.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SeleniumBasicFramework.Steps
{

    [Binding]
    public class LoginScenariosTablesSteps
    {
        IWebDriver driver;
        [Given(@"Im currently in the login page")]
        public void GivenImCurrentlyInTheLoginPage()
        {
            driver = new ChromeDriver();
            driver.Url = "http://demo.guru99.com/V4/";
        }
        
        [When(@"I have entered a valid (.*) and (.*)")]
        public void WhenIHaveEnteredAValidAnd(string username, string password)
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginWithParameters(username, password);
        }
        
        [Then(@"I would be able to login successfully to the site")]
        public void ThenIWouldBeAbleToLoginSuccessfullyToTheSite()
        {
            var homePage = new HomePage(driver);
            Assert.IsTrue(homePage.IsHeadingDisplayed());
            driver.Close();
        }
    }
}
