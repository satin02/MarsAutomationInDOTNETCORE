using System;
using TestProject.SDK;
using TestProject.SDK.Tests;
using TestProject.SDK.Tests.Helpers;

namespace MarsAutomationInCore
{
    public class Program : IWebTest
    {
        public ExecutionResult Execute(WebTestHelper helper)
        {
            var driver = helper.Driver;

            //Navigate to website
            driver.Navigate().GoToUrl("http://192.168.99.100:5000 ");
            SignUp signUp = new SignUp(driver);
            signUp.register();

            return ExecutionResult.Passed;
        }
    }

    public class TestSignIn : IWebTest
    {
        public ExecutionResult Execute(WebTestHelper helper)
        {
            var driver = helper.Driver;
            //Navigate to website
            driver.Navigate().GoToUrl("http://192.168.99.100:5000 ");
            SignIn signIn = new SignIn(driver);
            signIn.LoginSteps();

            Profile profile = new Profile(driver);



            return ExecutionResult.Passed;

        }
    }
}
