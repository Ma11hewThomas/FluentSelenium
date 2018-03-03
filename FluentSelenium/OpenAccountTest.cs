using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using FluentAssertions;

namespace FluentSelenium
{
    [TestClass]
    public class OpenAccountTest
    {
        private IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        
        [TestMethod]
        public void OpenAnAccountSuccessfully()
        {
            new HomePage(driver)
                .GoTo()
                .ClickOpenAccount();

            new OpenAccountPage(driver)
                .SetFullName("Matthew Thomas")
                .SetEmailAddress("MatthewThomas@MatthewThomas.Tech")
                .SetUsername("MatthewThomasGB")
                .SetPassword("Password")
                .ClickSubmit();

            new SuccessPage(driver).SuccessTextVisible().Should().BeTrue();
        }
















        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
