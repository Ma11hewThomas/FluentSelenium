using OpenQA.Selenium;

namespace FluentSelenium
{
    class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By openAccountButton = By.Id("openAccount");

        public void GoTo()
        {
            driver.Navigate().GoToUrl("http://matthewthomas.tech/fluent-selenium-playground/");
        }

        public void ClickOpenAccount()
        {
            driver.FindElement(openAccountButton).Click();
        }
    }
}
