using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsAutomationInCore
{
    class Profile
    {
        public IWebDriver driver;
        public Profile(IWebDriver driver)
        {
            this.driver = driver;
        }


    }
}
