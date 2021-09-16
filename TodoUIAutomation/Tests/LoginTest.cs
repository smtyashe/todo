using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TodoUIAutomation.Pages;

namespace TodoUIAutomation.Tests
{
    class LoginTest
    {

        IWebDriver webDriver = new ChromeDriver();
        
        [SetUp]
        public void Setup()
        {

            webDriver.Navigate().GoToUrl("http://localhost:3000/");
        }

        [Test]
        public void Login()
        {
            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.ClickLogin("smtyashe@gmail.com","test@1234");


            TodoPage todoPage = new TodoPage(webDriver);
            Assert.That(todoPage.isTodoPageDisplyed, Is.True);
            Assert.Pass();
        }

        [TearDown]
        public void tearDown()
        {
            webDriver.Quit();
            webDriver.Close();
        }
    }
}
