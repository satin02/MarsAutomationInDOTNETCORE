using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsAutomationInCore
{
    class SignIn
    {
        private IWebDriver driver;

        public SignIn(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Initialize Web Elements
        //Finding SignInTab
        public IWebElement SignInTab => driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));

        //Finding Email field
        IWebElement Email => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));

        //Finding Password field
        IWebElement Password => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));

        //Finding Login Btn
        IWebElement LoginBtn => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        #endregion

        public void LoginSteps()
        {


            //Click on Sign In tab
            SignInTab.Click();
            Thread.Sleep(500);

            //Enter the data in Username textbox
            Email.SendKeys("satinmeet@outlook.com");
            Thread.Sleep(500);

            //Enter the password 
            Password.SendKeys("********");
            Thread.Sleep(500);

            //Click on Login button
            LoginBtn.Click();
            Thread.Sleep(1500);

        }
    }
}
