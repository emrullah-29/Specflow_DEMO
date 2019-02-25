using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OnlineStore.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/h2")]
        [CacheLookup]
        public IWebElement Heading { get; set; }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public bool IsHeadingDisplayed()
        {
            return Heading.Displayed;
        }
    }
}