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

        public HomePage GoTo()
        {
            driver.Navigate().GoToUrl("http://matthewthomas.tech/fluent-selenium-playground/");
            return this;
        }

        public HomePage ClickOpenAccount()
        {
            driver.FindElement(openAccountButton).Click();
            return this;
        }
    }
}
