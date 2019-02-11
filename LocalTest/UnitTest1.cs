using MarsAutomationInCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject.SDK;
using TestProject.SDK.Common.Enums;

namespace LocalTest
{
    [TestClass]
    public class UnitTest1
    {
        private static string DevToken = "qloq1uDjFmIrbpuJXFE1M01VMPI3E8pfD4KgYxsttfk1";
        private static AutomatedBrowserType BrowserType = AutomatedBrowserType.Chrome;


        [TestMethod]
        public void TestSignUp()
        {
            using (Runner runner = RunnerFactory.Instance.CreateWeb(DevToken, BrowserType))
                runner.Run(new Program());

        }

        [TestMethod]
        public void TestSignIn()
        {
            using (Runner runner = RunnerFactory.Instance.CreateWeb(DevToken, BrowserType))
                runner.Run(new TestSignIn());
        }
    }

}
