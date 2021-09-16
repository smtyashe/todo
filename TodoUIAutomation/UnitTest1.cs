/*using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TodoUIAutomation
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

            
        }

        [Test]
        public void Test1()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("http://localhost:3000/");

            IWebElement username = webDriver.FindElement(By.Name("username"));
            username.Click();
            username.SendKeys("smtyashe@gmail.com");

            IWebElement password = webDriver.FindElement(By.Name("password"));
            password.Click();
            password.SendKeys("te1st@1234");

            IWebElement loginButton = webDriver.FindElement(By.XPath("//*[@id='root']/div/form/button"));

            loginButton.Click();

            var loginPage = webDriver.FindElement(By.XPath("//*[@id='root']/div/form/h1"));
            Assert.That(loginPage.Displayed, Is.True);
            Assert.Pass();
        }
    }
}*/