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
            var a = new ScriptUsingFacebook();
            a.GenerateFacebookHelpApi();
            //var dynamicGenerate = new DynamicCodeGeneration();
            //var classDefination = new ClassDefinationDTO
            //{
            //    Directives = new List<string> { "System" },
            //    NameSpace = new Defiantion { Name = "TestNamespace", Comments = new[] { "Test namespace comments." } },
            //    ClassDefination = new Defiantion { Name = "TestClass", Comments = new List<string> { "Test class comment" } },
            //    Methods = new List<MethodDefination> { new MethodDefination { Name = "TestMethod", Comments = new[] { "Test method comments" } } }
            //};
            //dynamicGenerate.GenerateClassCode(classDefination);
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
