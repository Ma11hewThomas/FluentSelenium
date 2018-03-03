using OpenQA.Selenium;

namespace FluentSelenium
{
    class OpenAccountPage
    {
        IWebDriver driver;

        internal OpenAccountPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By nameField = By.Id("name");
        private By emailField = By.Id("email");
        private By usernameField = By.Id("username");
        private By passwordField = By.Id("password");
        private By submitButton = By.Id("submit");

        internal void SetFullName(string fullName)
        {
            driver.FindElement(nameField).SendKeys(fullName);
        }

        internal void SetEmailAddress(string emailAddress)
        {
            driver.FindElement(emailField).SendKeys(emailAddress);
        }

        internal void SetUsername(string username)
        {
            driver.FindElement(usernameField).SendKeys(username);
        }

        internal void SetPassword(string password)
        {
            driver.FindElement(passwordField).SendKeys(password);
        }

        internal void ClickSubmit()
        {
            driver.FindElement(submitButton).Click();
        }
    }
}
