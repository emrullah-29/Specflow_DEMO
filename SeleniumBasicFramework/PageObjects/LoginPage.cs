using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OnlineStore.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "uid")]
        [CacheLookup]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "btnLogin")]
        [CacheLookup]
        public IWebElement Submit { get; set; }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void LoginWithParameters(string username, string password)
        {
            UserName.SendKeys(username);
            Password.SendKeys(password);
            Submit.Submit();
        }

        public void LoginToApplication()
        {
            UserName.SendKeys("mngr176797");
            Password.SendKeys("jaseteb");
            Submit.Submit();
        }
    }
}