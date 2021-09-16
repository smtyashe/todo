using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TodoUIAutomation.Pages
{
    class TodoPage
    {
        public TodoPage()
        {
        }

        public TodoPage(IWebDriver webdriver)
        {
            Driver = webdriver;
        }

        public IWebDriver Driver { get; private set; }

        IWebElement todoText => Driver.FindElement(By.XPath("//*[@id='root']/div/form/h1"));


        public bool isTodoPageDisplyed => todoText.Displayed;
    }
}
