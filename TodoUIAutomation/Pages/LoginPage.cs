using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TodoUIAutomation.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver webdriver)
        {
            Driver = webdriver;
        }

        public IWebDriver Driver { get; private set; }


        IWebElement txtUsername => Driver.FindElement(By.Name("username"));
        
      

            IWebElement txtPassword => Driver.FindElement(By.Name("password"));
   

            IWebElement loginButton => Driver.FindElement(By.XPath("//*[@id='root']/div/form/button"));


        public void ClickLogin(String uName, String pwd)
        {
            txtUsername.SendKeys(uName);
            txtPassword.SendKeys(pwd);
            loginButton.Click();
        } 
    }
}
