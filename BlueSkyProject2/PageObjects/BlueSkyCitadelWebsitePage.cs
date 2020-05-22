using BlueSkyProject2.Hooks;
using BlueSkyProject2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkyProject2.PageObjects
{
    class BlueSkyCitadelWebsitePage
    {
        IWebDriver driver;

        Waits waits = new Waits();

        IWebElement automationTestingForm => driver.FindElement(By.XPath("//*[@id='menu-item-2135']/a"));

        IWebElement singleLineText => driver.FindElement(By.Id("nf-field-135"));

        IWebElement selectOneTwoThree => driver.FindElement(By.XPath("//*[@id='nf-field-136']"));

        IWebElement email => driver.FindElement(By.Id("nf-field-124"));

        //IWebElement password => driver.FindElement(By.XPath("//*[@id='nf-field-144']"));

        IWebElement multiselect123 => driver.FindElement(By.CssSelector("#nf-field-137"));

        IWebElement selectRadio => driver.FindElement(By.Id("nf-label-class-field-138-1"));

        IWebElement selectCheckBox => driver.FindElement(By.Id("nf-label-field-139-2"));

        IWebElement selectCountry => driver.FindElement(By.CssSelector("#nf-field-140"));

        IWebElement dateFromCalender => driver.FindElement(By.CssSelector("input.pikaday__display.pikaday__display--pikaday.ninja-forms-field.nf-element.datepicker"));

        IWebElement singleCheckBox => driver.FindElement(By.CssSelector("#nf-label-field-142"));

        IWebElement paragraphText => driver.FindElement(By.XPath("//*[@id='nf-field-143']"));

        IWebElement submit => driver.FindElement(By.Id("nf-field-133"));

        IWebElement emailAddress => driver.FindElement(By.Name("email"));

        IWebElement passwordText => driver.FindElement(By.CssSelector("#nf-field-144"));


        IWebElement errorMessage => driver.FindElement(By.CssSelector("#nf-form-errors-9 > nf-errors > nf-section > div"));


        public string GetPageTitle => driver.Title;

        public string GetPageUrl => driver.Url;

        //public string GetPageTitle()
        //{
        //    return driver.Title;
        //}
        


        public void CheckErrorMessageIsDisplayed()
        {
            Assert.IsTrue(errorMessage.Displayed);
        }

        public string GetTextForError()
        {
            
            return  waits.WaitForElement(driver, errorMessage).Text;
            return waits.MyDriverWait(driver, errorMessage).Text;
            
        }


        public void Submit()
        {
            waits.WaitForElement(driver, submit).Click();
            //submit.Click();
        }


       public void EnterParagraphText()
        {
            paragraphText.SendKeys("Yetunde is a guru tester");

        }

        public void SingleCheckBox()
        {
            singleCheckBox.Click();
        }

        public void SelectDateFromCalender()
        {
            dateFromCalender.SendKeys("02/14/2020");
        }

        public void SelectUnitedKingdomFromCountry()
        {
           SelectElement select = new SelectElement(selectCountry);
           select.SelectByValue("GB");
        }

        public void SelectThreeFromCheckBox()
        {
            selectCheckBox.Click();
        }

        public void SelectTwoFromSelectRadio()
        {
            selectRadio.Click();

        }

        public void SelectMultiSelector()
        {
            SelectElement multiSelector = new SelectElement(multiselect123);
            multiSelector.SelectByText("One");
            multiSelector.SelectByText("Two");
        }

       // public void EnterPassword() 
       // {
          //  password.SendKeys("xxxxxxxx1");
       // }
        
        public void EnterEmail()
        {
            email.SendKeys("desolakin@gmail.com");
        }
     
        public void SelectTwoFromSelectOneTwoThree()
        {
            SelectElement select = new SelectElement(selectOneTwoThree);
            select.SelectByValue("two");
        }

        public void EnterSingleLineText()
        {
            singleLineText.SendKeys("Yetunde");
        }

         public void AutomationTestingForm()
        {
            automationTestingForm.Click();
        }
       
        public BlueSkyCitadelWebsitePage()
        {
            driver = Hook.driver;
        }


        public void NavigateToBlueSkycitadelwebsite()
        {
            driver.Navigate().GoToUrl("http://blueskycitadel.com/automation-testing-form");
        }

        public void NavigateToSite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterEmail(string email)
        {
            emailAddress.SendKeys(email);
        }


        public void EnterPassword(string password)
        {
            passwordText.SendKeys(password);
        }


    }
}
