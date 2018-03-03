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

        internal OpenAccountPage SetFullName(string fullName)
        {
            driver.FindElement(nameField).SendKeys(fullName);
            return this;
        }

        internal OpenAccountPage SetEmailAddress(string emailAddress)
        {
            driver.FindElement(emailField).SendKeys(emailAddress);
            return this;
        }

        internal OpenAccountPage SetUsername(string username)
        {
            driver.FindElement(usernameField).SendKeys(username);
            return this;
        }

        internal OpenAccountPage SetPassword(string password)
        {
            driver.FindElement(passwordField).SendKeys(password);
            return this;
        }

        internal OpenAccountPage ClickSubmit()
        {
            driver.FindElement(submitButton).Click();
            return this;
        }
    }
}
