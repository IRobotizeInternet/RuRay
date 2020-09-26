using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotizeYoutubeLibrary.Pages;

namespace RobotizeYoutube.LoginPageTests
{
    /// <summary>
    /// Summary description for LoginPageTest
    /// </summary>
    [TestClass]
    public class LoginPageTest
    {
        public LoginPageTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public TestContext TestContextInstance { get; set; }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            var page = new LoginPage();
        }
    }
}
