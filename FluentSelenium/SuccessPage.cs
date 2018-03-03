using OpenQA.Selenium;

namespace FluentSelenium
{
    class SuccessPage
    {
        IWebDriver driver;

        public SuccessPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal By successText = By.Id("successText");

        public bool SuccessTextVisible()
        {
            return driver.FindElement(successText).Displayed;
        }
    }
}
