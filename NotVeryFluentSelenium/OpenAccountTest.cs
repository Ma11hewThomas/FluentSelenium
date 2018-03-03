using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            HomePage homePage = new HomePage(driver);
            homePage.GoTo();
            homePage.ClickOpenAccount();

            OpenAccountPage openAccountPage = new OpenAccountPage(driver);
            openAccountPage.SetFullName("Matthew Thomas");
            openAccountPage.SetEmailAddress("MatthewThomas@MatthewThomas.Tech");
            openAccountPage.SetUsername("MatthewThomasGB");
            openAccountPage.SetPassword("Password");
            openAccountPage.ClickSubmit();

            SuccessPage successPage = new SuccessPage(driver);
            Assert.IsTrue(successPage.SuccessTextVisible());
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
