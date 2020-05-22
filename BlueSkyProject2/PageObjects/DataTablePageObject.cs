using BlueSkyProject2.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace BlueSkyProject2.PageObjects
{
    class DataTablePageObject
    {
        IWebDriver driver;

        IWebElement emailAddress => driver.FindElement(By.Name("email"));

        IWebElement passwordText => driver.FindElement(By.CssSelector("#nf-field-144"));

        public DataTablePageObject()
        {
            driver = Hook.driver;

        }
        
        public void EnterEmailAndPassword(string email, string password)
        {
            emailAddress.SendKeys(email);
            passwordText.SendKeys(password);
        }
    }
}
