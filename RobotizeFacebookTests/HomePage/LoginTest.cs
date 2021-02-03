using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotizeFacebook.Utilities;

namespace RobotizeFacebookTests.HomePage
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void TestLogInTotheHomePage()
        {
            // dummy test
            //var a = new ScriptUsingFacebook();
            //a.GenerateFacebookHelpApi();
            var dynamicGenerate = new DynamicCodeGeneration();
            dynamicGenerate.GenerateClassCode();
        }

        // Mark that this is a unit test method. (Required)
        [TestMethod]
        public void YouTestMethod()
        {
            // dummy test
            Assert.AreEqual("a", "a");
        }
    }
}
