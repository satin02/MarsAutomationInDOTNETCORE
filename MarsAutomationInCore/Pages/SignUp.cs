using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsAutomationInCore
{
    class SignUp
    {

        private IWebDriver driver;

        public SignUp(IWebDriver driver)
        {
            this.driver = driver;
        }
        #region Initialize Web Elements


        //Finding Join Btn
        IWebElement Join => driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/button"));

        //Identify FirstName Textbox
        IWebElement FirstName => driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/input"));


        //Identify LastName Textbox
        IWebElement LastName => driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[2]/input"));


        //Identify Email Textbox
        IWebElement Email => driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/input"));


        //Identify Password Textbox
        IWebElement Password => driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/input"));


        //Identify Confirm Password Textbox
        IWebElement ConfirmPassword => driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/input"));


        //Identify Term and Conditions Checkbox
        IWebElement Checkbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/div/input"));


        //Identify join button
        IWebElement JoinBtn => driver.FindElement(By.XPath("//*[@id='submit-btn']"));
      

        #endregion

        internal void register()
        {
            //Click on Join button
            Join.Click();

            //Enter FirstName
            FirstName.SendKeys("Satinder");

            //Enter LastName
            LastName.SendKeys("Kaur");

            //Enter Email
            Email.SendKeys("Satinmeet@outlook.com");

            //Enter Password
            Password.SendKeys("********");

            //Enter Password again to confirm
            ConfirmPassword.SendKeys("********");

            //Click on Checkbox
            Checkbox.Click();

            //Click on join button to Sign Up
            JoinBtn.Click();

        }

    }
}
